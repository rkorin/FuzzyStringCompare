using StringCompare.Comparers;
using StringCompare.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StringCompare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Entity> inputWords = new List<Entity>();
        List<ICompareMethod> comparers = new List<ICompareMethod>();
        List<SearchResult> results = new List<SearchResult>();
        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var sentence in global::StringCompare.Properties.Settings.Default.Dict)
            {
                var s = removePunctuation(sentence);
                if (string.IsNullOrWhiteSpace(s))
                    continue;
                AddToIndex(s);
            }
            for (var i = 0; i < (inputWords.Count - 1); ++i)
                for (var j = i + 1; j < inputWords.Count; ++j)
                {
                    bool found = false;
                    foreach (var s1 in inputWords[i].sentenses)
                    {
                        foreach (var s2 in inputWords[j].sentenses)
                        {
                            if (LevenshteinDistance.Compute(s1, s2) < 5)
                            {
                                found = true;
                                break;
                            }
                        }
                        if (found) break;
                    }
                    if (found)
                    {
                        inputWords[i].sentenses.AddRange(inputWords[j].sentenses);
                        inputWords[j].sentenses.Clear();
                    }
                }

            for (var i = 0; i < inputWords.Count; ++i)
            {
                if (inputWords[i].sentenses.Count == 0)
                    inputWords.RemoveAt(i);
            }

            cbw.DataSource = inputWords;

            comparers = new List<ICompareMethod>();
            comparers.Add(new LevenshtainComparer());
            comparers.Add(new Sift4DistanceComparer());
            comparers.Add(new CompareOrdinalComparer());

            comparers.ForEach(fe => fe.init(this.inputWords));
            t.Enabled = true;
        }

        string removePunctuation(string sentence)
        {
            StringBuilder sb = new StringBuilder();
            var matches = Regex.Matches(sentence.ToLower().Trim(), "[a-z0-9_]+", RegexOptions.CultureInvariant);
            foreach (Match m in matches)
                sb.Append(m.Value).Append(" ");
            return sb.ToString().Trim();
        }

        int n = 1;
        void AddToIndex(string sentence)
        {
            foreach (var entity in inputWords)
            {
                foreach (var isentence in entity.sentenses)
                {
                    if (LevenshteinDistance.Compute(sentence, isentence) < 5)
                    {
                        entity.sentenses.Add(sentence);
                        return;
                    }
                }
            }
            inputWords.Add(new Entity { sentenses = new List<string> { sentence } });
            ++n;
        }

        private void cbw_SelectedIndexChanged(object sender, EventArgs e)
        {
            Entity si = cbw.SelectedItem as Entity;
            if (si != null)
                lw.DataSource = si.sentenses;
        }

        Random r = new Random();
        char[] c = "qwertyuiopasdfghjklzxcvbnm _".ToCharArray();

        private void t_Tick(object sender, EventArgs e)
        {
            t.Enabled = false;
            var len = inputWords.Count;
            var entity = inputWords[r.Next(len)];
            var s = entity.sentenses[r.Next(entity.sentenses.Count)];
            var original_s = s;
            bool doModify = (r.Next(2) == 0);
            if (doModify)
            {
                s = swapWords(s, r.Next(3));
                if (LevenshteinDistance.Compute(original_s, s) < 20)
                { s = swapChars(s, r.Next(4)); }
                if (LevenshteinDistance.Compute(original_s, s) < 20)
                { s = changeChars(s, r.Next(6)); }
            }

            comparers.ForEach(fe =>
            {
                var sw = Stopwatch.StartNew();
                ICompareResult result = null;
                for (var i = 0; i < 10; ++i)
                    result = fe.search(s);
                sw.Stop();
                this.results.Add(new SearchResult
                {
                    isModified = true,
                    method = fe,
                    originalEntity = entity,
                    result = result,
                    sentense = original_s,
                    ms = sw.ElapsedMilliseconds,
                    founded = entity.id == (result?.BestResult?.id ?? Guid.Empty)
                });
            });

            l.Text = $"There are {this.results.Count} results ";
            {
                var lr = this.results.Where(w => w.method.name == "LevenshtainComparer").ToList();
                var founded = (double)lr.Where(w => w.founded).Count() / (double)lr.Count * 100;
                var atime = (double)lr.Sum(s1 => s1.ms) / (double)lr.Count;
                ll.Text = $"Levenshtain: Average time: { atime:0.00}, founded: {founded:0.00}%";
            }

            {
                var lr = this.results.Where(w => w.method.name == "Sift4DistanceComparer").ToList();                
                var founded = (double)lr.Where(w => w.founded).Count() / (double)lr.Count * 100;
                var atime = (double)lr.Sum(s1 => s1.ms) / (double)lr.Count;
                d4.Text = $"Sift4DistanceComparer: Average time: { atime:0.00}, founded: {founded:0.00}%";
            }

            {
                var lr = this.results.Where(w => w.method.name == "CompareOrdinalComparer").ToList();
                var founded = (double)lr.Where(w => w.founded).Count() / (double)lr.Count * 100;
                var atime = (double)lr.Sum(s1 => s1.ms) / (double)lr.Count;
                lco.Text = $"CompareOrdinalComparer: Average time: { atime:0.00}, founded: {founded:0.00}%";
            }
            

            t.Enabled = true;
        }

        private string changeChars(string s, int v)
        {
            if (v == 0) return s;
            StringBuilder sb = new StringBuilder(s);
            int r1 = r.Next(s.Length);
            int r2 = r.Next(c.Length);
            sb[r1] = c[r2];
            return changeChars(sb.ToString(), v - 1);
        }

        private string swapChars(string s, int v)
        {
            if (v == 0) return s;
            StringBuilder sb = new StringBuilder(s);
            int r1 = r.Next(s.Length);
            int r2 = r.Next(s.Length);
            var t = sb[r1];
            sb[r1] = sb[r2];
            sb[r2] = t;
            return swapChars(sb.ToString(), v - 1);
        }

        private string swapWords(string s, int v)
        {
            if (v == 0) return s;
            StringBuilder sb = new StringBuilder();
            var matches = Regex.Matches(s.ToLower().Trim(), "[a-z0-9_]+", RegexOptions.CultureInvariant);
            List<string> words = new List<string>();
            foreach (Match smm in matches)
                words.Add(smm.Value);
            int r1 = r.Next(words.Count);
            int r2 = r.Next(words.Count);
            var t = words[r1];
            words[r1] = words[r2];
            words[r2] = t;
            foreach (var m in words)
                sb.Append(m).Append(" ");
            return swapWords(sb.ToString(), v - 1);
        }
    }
}

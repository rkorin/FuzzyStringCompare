using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringCompare.Models;
using System.Text.RegularExpressions;

namespace StringCompare.Comparers
{
    public class DamerauLevenshteinComparer : ICompareMethod
    {
        public string name { get { return "DamerauLevenshteinComparer"; } }

        private List<Entity> models;
        public void init(List<Entity> m)
        {
            this.models = m;
        }

        string removePunctuation(string sentence)
        {
            StringBuilder sb = new StringBuilder();
            var matches = Regex.Matches(sentence.ToLower().Trim(), "[a-z0-9_]+", RegexOptions.CultureInvariant);
            foreach (Match m in matches)
                sb.Append(m.Value).Append(" ");
            return sb.ToString().Trim();
        }

        public ICompareResult search(string sentence)
        {
            var s = removePunctuation(sentence);
            var minDistance = 10000;
            Entity minE = null;
            foreach (var entity in this.models)
            {
                foreach (var sent in entity.sentenses)
                {
                    var d = Distance(s, sent);
                    if (d == 0)
                        return new CompareResult { Success = true, BestResult = entity, Rank = 100 };
                    if (d < minDistance)
                    {
                        minDistance = d;
                        minE = entity;
                    }
                }
            }
            if (s.Length < 5 && minDistance == 1)
                return new CompareResult { Success = true, BestResult = minE, Rank = 95 };
            if (s.Length < 8 && minDistance <= 2)
                return new CompareResult { Success = true, BestResult = minE, Rank = 95 - minDistance * 5 };
            if (s.Length < 12 && minDistance <= 3)
                return new CompareResult { Success = true, BestResult = minE, Rank = 90 - minDistance * 10 };

            var r = 60 - minDistance * 5;
            if (r < 0) r = 0;
            return new CompareResult { Success = false, BestResult = minE, Rank = r };
        }

        public int Distance(string source, string target)
        {
            if (AnyStringIsNullOrEmpty(source, target))
                return LengthOfTheLongestString(source, target);

            var score = PrepareScoreMatrix(source, target);
            var sd = GetSortedDictionaryWithAllLettersFrom(source, target);

            for (var i = 1; i <= source.Length; i++)
            {
                var DB = 0;
                for (var j = 1; j <= target.Length; j++)
                {
                    var i1 = sd[target[j - 1]];
                    var j1 = DB;

                    if (source[i - 1] == target[j - 1])
                    {
                        score[i + 1, j + 1] = score[i, j];
                        DB = j;
                    }
                    else
                    {
                        var a = score[i, j];
                        var b = score[i + 1, j];
                        var c = score[i, j + 1];

                        score[i + 1, j + 1] = Math.Min(a, Math.Min(b, c)) + 1;
                    }

                    var x = score[i + 1, j + 1];
                    var y = score[i1, j1] + (i - i1 - 1) + 1 + (j - j1 - 1);

                    score[i + 1, j + 1] = Math.Min(x, y);
                }

                sd[source[i - 1]] = i;
            }

            return score[source.Length + 1, target.Length + 1];
        }

        private int[,] PrepareScoreMatrix(string source, string target)
        {
            var score = new int[source.Length + 2, target.Length + 2];

            var INF = source.Length + target.Length;
            score[0, 0] = INF;
            for (var i = 0; i <= source.Length; i++)
            {
                score[i + 1, 1] = i;
                score[i + 1, 0] = INF;
            }
            for (var j = 0; j <= target.Length; j++)
            {
                score[1, j + 1] = j;
                score[0, j + 1] = INF;
            }

            return score;
        }

        private bool AnyStringIsNullOrEmpty(string string1, string string2)
        {
            return String.IsNullOrEmpty(string1)
                || String.IsNullOrEmpty(string2);
        }

        private int LengthOfTheLongestString(params string[] strings)
        {
            return strings
                .Select(word => word ?? string.Empty)
                .Max(word => word.Length);
        }

        private SortedDictionary<char, int> GetSortedDictionaryWithAllLettersFrom(params string[] words)
        {
            var letterDictionary = words
                .SelectMany(letter => letter)
                .Distinct()
                .ToDictionary(key => key, value => 0);

            return new SortedDictionary<char, int>(letterDictionary);
        }
    }
}

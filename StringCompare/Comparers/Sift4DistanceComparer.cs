using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringCompare.Models;
using System.Text.RegularExpressions;

namespace StringCompare.Comparers
{
    public class Sift4DistanceComparer : ICompareMethod
    {
        public string name { get { return "Sift4DistanceComparer"; } }

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
            var minDistance = 0;
            Entity minE = null;
            foreach (var entity in this.models)
            {
                foreach (var sent in entity.sentenses)
                {
                    var d = Sift4Distance(s, sent);
                    if (d == 100)
                        return new CompareResult { Success = true, BestResult = entity, Rank = d };
                    if (d > minDistance)
                    {
                        minDistance = d;
                        minE = entity;
                    }
                }
            }
            return new CompareResult { Success = minDistance > 90, BestResult = minE, Rank = minDistance };
        }

        public static int Sift4Distance(string s1, string s2, int maxOffset = 10)
        {
            var l1 = s1 == null ? 0 : s1.Length;
            var l2 = s2 == null ? 0 : s2.Length;

            if (l1 == 0) return l2;
            if (l2 == 0) return l1;

            var c1 = 0;  //cursor for string 1
            var c2 = 0;  //cursor for string 2
            var lcss = 0;  //largest common subsequence
            var local_cs = 0; //local common substring

            while ((c1 < l1) && (c2 < l2))
            {
                if (s1[c1] == s2[c2])
                {
                    local_cs++;
                }
                else
                {
                    lcss += local_cs;
                    local_cs = 0;
                    if (c1 != c2)
                    {
                        c1 = c2 = Math.Max(c1, c2);
                    }
                    //if matching tokens are found, remove 1 from both cursors (they get incremented at the end of the loop)
                    //so that we can have only one code block handling matches 
                    for (var i = 0; i < maxOffset && (c1 + i < l1 && c2 + i < l2); i++)
                    {
                        if ((c1 + i < l1) && s1[c1 + i] == s2[c2])
                        {
                            c1 += i - 1;
                            c2--;
                            break;
                        }
                        if ((c2 + i < l2) && s1[c1] == s2[c2 + i])
                        {
                            c1--;
                            c2 += i - 1;
                            break;
                        }
                    }
                }
                c1++;
                c2++;
            }
            lcss += local_cs;

            var result = (Math.Max(l1, l2) - lcss);
            if (result == 0)
                return 100;
            if (result < 0)
                result *= -1;
            if (result > 100)
                result = 100;

            return 100 - result;
        }
    }
}

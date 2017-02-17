using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringCompare.Models;
using System.Text.RegularExpressions;

namespace StringCompare.Comparers
{
    public class BitapComparer : ICompareMethod
    {
        public string name { get { return "BitapComparer"; } }

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
                    var d = SearchString(s, sent);
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

        public  int SearchString(string text, string pattern)
        {
            int m = pattern.Length;
            int R;
            int[] patternMask = new int[128];
            int i;

            if (string.IsNullOrEmpty(pattern)) return 0;
            if (m > 31) return -1; //Error: The pattern is too long!

            R = ~1;

            for (i = 0; i <= 127; ++i)
                patternMask[i] = ~0;

            for (i = 0; i < m; ++i)
                patternMask[pattern[i]] &= ~(1 << i);

            for (i = 0; i < text.Length; ++i)
            {
                R |= patternMask[text[i]];
                R <<= 1;

                if (0 == (R & (1 << m)))
                    return (i - m) + 1;
            }

            return -1;
        }
    }
}

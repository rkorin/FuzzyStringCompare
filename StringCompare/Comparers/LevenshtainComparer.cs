using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringCompare.Models;
using System.Text.RegularExpressions;

namespace StringCompare.Comparers
{
    public class LevenshtainComparer : ICompareMethod
    {
        public string name { get { return "LevenshtainComparer"; } }

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
                    var d = LevenshteinDistance.Compute(s, sent);
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
    }
}

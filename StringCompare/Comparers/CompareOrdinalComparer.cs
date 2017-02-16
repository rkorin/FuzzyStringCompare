using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringCompare.Models;
using System.Text.RegularExpressions;

namespace StringCompare.Comparers
{
    public class CompareOrdinalComparer : ICompareMethod
    {
        public string name { get { return "CompareOrdinalComparer"; } }

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
                    var d = CompareOrdinal(s, sent);
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

        public static Int32 CompareOrdinal(string s1, string s2)
        {
            var result = string.CompareOrdinal(s1, s2);
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

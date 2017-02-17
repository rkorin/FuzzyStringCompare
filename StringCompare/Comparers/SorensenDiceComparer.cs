using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringCompare.Models;
using System.Text.RegularExpressions;

namespace StringCompare.Comparers
{
    class SorensenDiceComparer : ICompareMethod
    {
   

        public string name
        {
            get
            {
                return "SorensenDiceComparer";
            }
        }

        public void init(List<Entity> m)
        {
            this.models = m;
        }

        private List<Entity> models;

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
            double minDistance = 0.0;
            Entity minE = null;
            foreach (var entity in this.models)
            {
                foreach (var sent in entity.sentenses)
                {
                    var d = DiceMatch(s, sent);
                    if (d == 1.0)
                        return new CompareResult { Success = true, BestResult = entity, Rank = 100 };
                    if (d > minDistance)
                    {
                        minDistance = d;
                        minE = entity;
                    }
                }
            }

            return new CompareResult { Success = minDistance > 0.7, BestResult = minE, Rank = (int)(minDistance * 100) };
        }


        public static double DiceMatch(string string1, string string2)
        {
            if (string.IsNullOrEmpty(string1) || string.IsNullOrEmpty(string2))
                return 0;

            if (string1 == string2)
                return 1;

            int strlen1 = string1.Length;
            int strlen2 = string2.Length;

            if (strlen1 < 2 || strlen2 < 2)
                return 0;

            int length1 = strlen1 - 1;
            int length2 = strlen2 - 1;

            double matches = 0;
            int i = 0;
            int j = 0;

            while (i < length1 && j < length2)
            {
                string a = string1.Substring(i, 2);
                string b = string2.Substring(j, 2);
                int cmp = string.Compare(a, b);

                if (cmp == 0)
                    matches += 2;

                ++i;
                ++j;
            }

            return matches / (length1 + length2);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringCompare.Models;
using System.Text.RegularExpressions;

namespace StringCompare.Comparers
{
    public class ngrammsComparrer : ICompareMethod
    {
        public string name
        {
            get
            {
                return "ngrammsComparrer";
            }
        }

        private List<Entity> models;

        private Dictionary<int, Entity> d = new Dictionary<int, Entity>();
        private Dictionary<string, int> ngrammToInt = new Dictionary<string, int>();
        private char[] chars = "qwertyuiopasdfghjklzxcvbnm".ToCharArray();
        public void init(List<Entity> m)
        {
            this.models = m;
            m.ForEach(fe =>
            {
                fe.sentenses
                Regex.Matches(
                    )

            });
        }

        public ICompareResult search(string sentence)
        {
            throw new NotImplementedException();
        }
    }
}

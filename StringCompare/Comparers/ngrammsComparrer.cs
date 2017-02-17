//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using StringCompare.Models;
//using System.Text.RegularExpressions;

//namespace StringCompare.Comparers
//{
//    public class ngrammsComparrer : ICompareMethod
//    {
//        public string name
//        {
//            get
//            {
//                return "ngrammsComparrer";
//            }
//        }

//        private List<Entity> models;
//        const int m = 17576;
//        private Dictionary<int, Entity> d = new Dictionary<int, Entity>();
//        private List<int>[] ngMap = null;
//        private int[,,] ngrammToInt = new int[128, 128, 128];
//        private char[] chars = "qwertyuiopasdfghjklzxcvbnm_".ToCharArray();
//        public void init(List<Entity> m)
//        {

//            int n = 0;
//            byte minc = (byte)'a';
//            List<List<int>> nm = new List<List<int>>();
//            for (var i = 0; i < chars.Count(); ++i)
//                for (var j = 0; j < chars.Count(); ++j)
//                    for (var k = 0; k < chars.Count(); ++k)
//                    {
//                        ngrammToInt[(byte)(chars[i]) - minc, (byte)(chars[j]) - minc, (byte)(chars[k]) - minc] = n;
//                        nm[n] = new List<int>();
//                        ++n;
//                    }
//            var ngMap = nm.ToArray();

//            int sn = 0;
//            m.ForEach(fe =>
//            {
//                fe.sentenses.ForEach(sfe =>
//                {
//                    sn++;
//                    d[sn] = fe;
//                    var matches = Regex.Matches(sfe.ToLower().Trim(), "[a-z0-9_]+", RegexOptions.CultureInvariant);
//                    foreach (Match m1 in matches)
//                    {
//                        string mVal = m1.Value;
//                        if (mVal.Length < 3)
//                            mVal = mVal.PadRight(3, '_');
//                        for (var i = 2; i < mVal.Length; ++i)
//                        {
//                            var ngId = ngrammToInt[(byte)(mVal[i-2]) - minc, (byte)(mVal[i-1]) - minc, (byte)(mVal[i]) - minc];
//                            ngMap[ngId].Add(sn);
//                        }

//                    }
//                });
//            });
//        }

//        public ICompareResult search(string sentence)
//        {
//            return new CompareResult { BestResult = null, Rank = 0, Success = false };
//        }
//    }
//}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StringCompare.Models;

namespace StringCompare.Comparers
{
    public class CompareResult : ICompareResult
    {
        public Entity BestResult { get; set; }
        public int Rank { get; internal set; }
        public bool Success { get; set; }
    }
}

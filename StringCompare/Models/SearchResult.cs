using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCompare.Models
{
    public class SearchResult
    {
        public ICompareMethod method { get; set; }
        public ICompareResult result { get; set; }
        public string sentense { get; set; }
        public bool isModified { get; set; }
        public Entity originalEntity { get; set; }
        public long ms { get; internal set; }
        public bool founded { get; internal set; }
    }
}

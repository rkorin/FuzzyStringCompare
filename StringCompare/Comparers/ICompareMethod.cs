using StringCompare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCompare
{
    public interface ICompareMethod
    {
        string name { get; }
        void init(List<Entity> models);
        ICompareResult search(string sentence);
    }

    public interface ICompareResult
    {
        bool Success { get; set; }
        Entity BestResult { get; set; }
    }
}

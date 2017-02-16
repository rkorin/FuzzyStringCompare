using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCompare.Models
{
    public class Entity
    {
        public Guid id { get; set; } = Guid.NewGuid();
        public List<string> sentenses { get; set; } = new List<string>();
        public override string ToString()
        {
            return sentenses?.First()?.Replace(' ', '-') ?? id.ToString();
        }
    }
}

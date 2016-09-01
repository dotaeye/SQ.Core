using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ.Core.UI
{
    public class Cascader
    {
        public string Label { get; set; }

        public string Value { get; set; }

        public string ParentId { get; set; }

        public List<Cascader> Children { get; set; }
    }
}

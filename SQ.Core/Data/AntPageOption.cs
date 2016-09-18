using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ.Core.Data
{
    public class AntPageOption
    {
        public int Id { get; set; }

        public int Results { get; set; }

        public int Page { get; set; }

        public string SortField { get; set; }

        public string SortOrder { get; set; }

    }
}

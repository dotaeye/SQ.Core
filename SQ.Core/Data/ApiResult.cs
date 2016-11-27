using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ.Core.Data
{
    public class ApiResult<T>
    {
        public int Code { get; set; }

        public string Info { get; set; }

        public T Data { get; set; }
    }
}

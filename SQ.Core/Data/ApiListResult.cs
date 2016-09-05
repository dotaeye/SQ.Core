using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ.Core.Data
{
    public class ApiListResult<T>
    {
        public ApiListResult(IList<T> source, int page, int size, int count)
        {
            this.Data = source;
            this.CurrentPage = page + 1;
            this.PageSize = size;
            this.RecordCount = count;
        }

        public IList<T> Data { get; set; }

        public int CurrentPage { get; set; }

        public int RecordCount { get; set; }

        public int PageSize { get; set; }
    }
}

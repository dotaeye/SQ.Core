using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQ.Core.Data
{
    public static class QueryableExtensions
    {
        public static IPagedList<T> Paging<T>(this IQueryable<T> source, int pageIndex, int pageSize)
        {
            var result = new PagedList<T>(source, pageIndex, pageSize);
            return result;
        }

        public static IPagedList<T> Paging<T>(this IQueryable<T> source, int pageIndex, int pageSize, int count)
        {
            var result = new PagedList<T>(source, pageIndex, pageSize, count);
            return result;
        }
    }
}

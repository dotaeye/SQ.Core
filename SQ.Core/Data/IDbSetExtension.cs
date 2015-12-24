using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SQ.Core.Data
{
    public static class IDbSetExtension
    {
        public static Task<TEntity> FindAsync<TEntity>(this IDbSet<TEntity> set, params object[] keyValues)
            where TEntity : class
        {
            return Task<TEntity>.Run(() =>
            {
                var entity = set.Find(keyValues);
                return entity;
            });
        }
    }
}

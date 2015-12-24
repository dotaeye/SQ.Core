using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace SQ.Core.Data
{
    public partial interface IRepository<T> where T : BaseEntity
    {
        T GetById(object id);

        Task<T> GetByIdAsync(object id);

        void Insert(T entity);
        void Insert(IEnumerable<T> entities);

        Task<int> InsertAsync(IEnumerable<T> entities);
        Task<int> InsertAsync(T entity);

        void Update(T entity);
        void Update(IEnumerable<T> entities);

        Task<int> UpdateAsync(T entity);
        Task<int> UpdateAsync(IEnumerable<T> entities);

        void Delete(T entity);
        void Delete(IEnumerable<T> entities);

        Task<int> DeleteAsync(T entity);
        Task<int> DeleteAsync(IEnumerable<T> entities);

        IQueryable<T> Table { get; }

    }
}

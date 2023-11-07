using System.Linq.Expressions;

namespace automotive.BL.Contexts.Interfaces
{
    internal interface IBaseRepository<T> 
        where T : class
    {
        Task <IEnumerable<T>> Get(Expression<Func<T, bool>> expression);
        void Add(T value);
        void Remove(T value);
        void Update(T value);
        Task SaveChangesAsync();
    }
}
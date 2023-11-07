using automotive.BL.Contexts.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace automotive.BL.Contexts
{
    public class BaseRepository<T> : IBaseRepository<T>
		where T : class
	{
		private readonly DbContext _dbContext;

		public BaseRepository(DbContext dbContext) 
        {
			_dbContext = dbContext;
		}

        public async Task<IEnumerable<T>> Get(Expression<Func<T, bool>> expression) 
        {
            return await _dbContext.Set<T>().Where(expression).ToListAsync();
		}

        public void Add(T value) 
        {
		    _dbContext.Set<T>().Add(value);
        }

        public void Remove(T value)
        {
			_dbContext.Set<T>().Remove(value);
        }

        public void Update(T value) 
        {
			_dbContext.Set<T>().Update(value);
        }

        public async Task SaveChangesAsync()
        {
			await _dbContext.SaveChangesAsync();
        }
    }
}

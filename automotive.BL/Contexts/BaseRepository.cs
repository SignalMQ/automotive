using automotive.BL.Contexts.Interfaces;

namespace automotive.BL.Contexts
{
    internal class BaseRepository: IBaseRepository
    {
        private readonly BaseContext baseContext = new();

        public Task AddAsync<T>(T value) where T : class
        {
            baseContext.Add(value);
            return Task.CompletedTask;
        }

        public Task RemoveAsync<T>(T value) where T: class
        {
            baseContext.Remove(value);
            return Task.CompletedTask;
        }

        public Task UpdateAsync<T>(T value) where T: class
        {
            baseContext.Update(value);
            return Task.CompletedTask;
        }

        public Task SaveChanges()
        {
            baseContext.SaveChanges();
            return Task.CompletedTask;
        }
    }
}

namespace automotive.BL.Contexts.Interfaces
{
    internal interface IBaseRepository
    {
        Task AddAsync<T>(T value) where T : class;
        Task RemoveAsync<T>(T value) where T : class;
        Task UpdateAsync<T>(T value) where T : class;
        Task SaveChanges();
    }
}
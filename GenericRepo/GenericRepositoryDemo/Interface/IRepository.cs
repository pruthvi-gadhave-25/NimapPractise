namespace GenericRepositoryDemo.Interface
{
    public interface IRepository<T> where T :class
    {

        Task<IEnumerable<T>>GetAllAsync();
        Task<T> GetByIdAsync(object id);
        Task Add(T entity);
        Task Update(T entity);
        Task Delete(T entity);
        Task Save();
    }
}

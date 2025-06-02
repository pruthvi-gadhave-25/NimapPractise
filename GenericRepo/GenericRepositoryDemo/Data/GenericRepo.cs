using GenericRepositoryDemo.Interface;
using Microsoft.EntityFrameworkCore;

namespace GenericRepositoryDemo.Data
{
    public class GenericRepo<T> : IRepository<T> where T : class
    {
        private readonly AppDbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public GenericRepo(AppDbContext dbContext )
        {
            _dbContext = dbContext;
            _dbSet =_dbContext.Set<T>();
        }
        public  async Task Add(T entity)
        {   
            _dbSet.Add(entity);        
        }
        public async Task<T> GetByIdAsync(object id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task Delete(T entity)
        {
            _dbSet.Remove(entity);
            
          
        }
       
        public async Task<IEnumerable<T>> GetAllAsync()
        {
         return  await _dbSet.ToListAsync();
                    
        }

        public  async Task Update(T entity)
        {
            _dbSet.Update(entity);           
        }
      
        public async Task Save()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}

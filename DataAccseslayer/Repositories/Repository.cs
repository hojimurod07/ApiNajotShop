using DataAccseslayer.Entities;
using DataAccseslayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Buffers.Text;
using System.Security.AccessControl;

namespace DataAccseslayer.Repositories
{
    public class Repository<T>(AppDbContext dbContext) : IRepository<T> where T : BaseEntity
    {
        private readonly DbSet<T> _dbSet = dbContext.Set<T>();
        protected readonly AppDbContext _dbContext = dbContext;

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(T entity)
        {
            _dbSet.Remove(entity);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
         => await _dbSet.ToListAsync(); 

        public async Task<T?> GetByIdAsync(int id)
            => await _dbSet.FirstOrDefaultAsync(x => x.Id == id);

        public async Task UpdateAsync(T entity)
        {
            _dbSet.Update(entity);
            await _dbContext.SaveChangesAsync();
        }
    }
}

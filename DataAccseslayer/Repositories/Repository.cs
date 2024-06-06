using DataAccseslayer.Entities;
using DataAccseslayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Buffers.Text;

namespace DataAccseslayer.Repositories
{
    public class Repository<T>(AppDbContext dbContext) : IRepository<T> where T : BaseEntity
    {
        private readonly DbSet<T> _dbSet = dbContext.Set<T>();
        private readonly AppDbContext _dbContext = dbContext;

        public Task AddAsync(T entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IQueryable<T>> GetAllAsync()
        {
            var enties  =  _dbSet.AsQueryable();
            return enties;
        }

        public Task<T> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(T entity)
        {
            throw new NotImplementedException();
        }
    }
}

using DataAccseslayer.Entities;
using DataAccseslayer.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace DataAccseslayer.Repositories
{
    public class UserRepository(AppDbContext dbContext) : Repository<User>(dbContext), IUserInterface
    {
        public async Task<User?> GetByEmailAsync(string email)
        {
               return await _dbContext.Users.FirstOrDefaultAsync(mail=>mail.Email == email);
        }
    }
}

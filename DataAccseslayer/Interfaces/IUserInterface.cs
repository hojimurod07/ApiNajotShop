using DataAccseslayer.Entities;

namespace DataAccseslayer.Interfaces
{
    public interface IUserInterface:IRepository<User>
    {
        Task<User?> GetByEmailAsync(string email);
    }
}

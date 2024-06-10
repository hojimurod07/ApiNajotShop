using DataAccseslayer.Entities;
using DataAccseslayer.Interfaces;

namespace DataAccseslayer.Repositories
{
    public class CarRepository(AppDbContext dbContext):Repository<Car>(dbContext),ICarInterface
    {
    }
}

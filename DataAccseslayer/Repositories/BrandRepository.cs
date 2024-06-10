using DataAccseslayer.Entities;
using DataAccseslayer.Interfaces;

namespace DataAccseslayer.Repositories
{
    public class BrandRepository(AppDbContext dbContext) : Repository<Brand>(dbContext),IBrandInterface
    {
    }
}

using DataAccseslayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccseslayer
{
    public class AppDbContext(DbContextOptions<AppDbContext> options):DbContext(options)
    {
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<User> Users { get; set; }

    }
}

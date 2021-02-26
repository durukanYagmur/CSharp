using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class RentCarContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server = (localdb)\MSSQLLocalDB; Database=RentCar; Trusted_Connection = true ");
        }

        DbSet<Car> Cars { get; set; }
        DbSet<Color> Colors { get; set; }
        DbSet<Brand> Brands { get; set; }
    }
}

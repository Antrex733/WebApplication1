using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication11.Entities
{
    public class RestaurantDbContext: DbContext
    {
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Address> addresses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}

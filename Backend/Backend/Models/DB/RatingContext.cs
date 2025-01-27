using Microsoft.EntityFrameworkCore;

namespace Backend.Models.DB
{
    public class RatingContext : DbContext
    {
        public DbSet<Rating> Ratings { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<Provider> Providers { get; set; }



        public string DbPath { get; set; }

        public RatingContext( DbContextOptions<RatingContext> options ) : base(options)
        {
            DbPath = Path.Combine(Directory.GetCurrentDirectory(), "data.db");
            //
            Database.EnsureCreated();
        }

        protected override void OnConfiguring( DbContextOptionsBuilder optionsBuilder ) => optionsBuilder.UseSqlite($"Data Source={DbPath}");


    }
}

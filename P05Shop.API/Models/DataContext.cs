using Microsoft.EntityFrameworkCore;
using P06Shop.Shared.MovieModel;
using P07Shop.DataSeeder;
using P06Shop.Shared.Auth;
namespace P05Shop.API.Models
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            
        }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<User> Users { get; set; }  

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // fluent api 
        
            modelBuilder.Entity<Movie>()
                .Property(m => m.Title)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Movie>()
                .Property(m => m.Director)
                .IsRequired()
                .HasMaxLength(100);

            modelBuilder.Entity<Movie>()
             .HasKey(m => m.Id);
            

           

            modelBuilder.Entity<Movie>().HasData(MovieSeeder.GenerateMovieData());
        }
    }
}
// instalacja dotnet ef 
//dotnet tool install --global dotnet-ef

// aktualizacja 
//dotnet tool update --global dotnet-ef

// dotnet ef migrations add [nazwa_migracji]
// dotnet ef database update 


// cofniecie migraji niezaplikowanych 
//dotnet ef migrations remove
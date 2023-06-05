using Microsoft.EntityFrameworkCore;

namespace CretaceousApi.Models
{
  public class CretaceousApiContext : DbContext
  {
    public DbSet<Animal> Animals { get; set; }
    public CretaceousApiContext(DbContextOptions<CretaceousApiContext> options) : base(options)
    {
    }
    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Animal>()
          .HasData(
            new Animal { AnimalId = 1, Name = "Scorpo", Species = "Woolly Mammoth", Age = 7 },
            new Animal { AnimalId = 2, Name = "DangleDoo", Species = "Dinosaur", Age = 10 },
            new Animal { AnimalId = 3, Name = "Flexorina", Species = "Dinosaur", Age = 2 },
            new Animal { AnimalId = 4, Name = "Zibzab", Species = "Shark", Age = 4 },
            new Animal { AnimalId = 5, Name = "BigFrank", Species = "Dinosaur", Age = 22 }
          );
    }
  }
}
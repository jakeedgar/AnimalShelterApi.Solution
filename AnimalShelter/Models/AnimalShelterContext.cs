using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AnimalShelter.Models
{
    public class AnimalShelterContext : IdentityDbContext<ApplicationUser>
    {

        public DbSet<Animal> Animals { get; set; }

        public AnimalShelterContext(DbContextOptions<AnimalShelterContext> options)
            : base(options)
        {

        }
        // protected override void OnModelCreating(ModelBuilder builder)
        // {
        //   builder.Entity<Animal>()
        //       .HasData(
        //           new Animal 
        //           { 
        //             AnimalId = 1, 
        //             Name = "Sarah", 
        //             Breed = "Unicorn",
        //             Color = "Clear", 
        //             Age = 7, 
        //             Price = 1
        //           },
        //           new Animal 
        //           { 
        //             AnimalId = 2, 
        //             Name = "Nick", 
        //             Breed = "Dragon",
        //             Color = "Green", 
        //             Age = 108, 
        //             Price = 0
        //           },
        //           new Animal 
        //           { 
        //             AnimalId = 3, 
        //             Name = "Jeremy", 
        //             Breed = "Minotaur",
        //             Color = "Yellow", 
        //             Age = 12, 
        //             Price = 324
        //           }
        //       );
        // }
    }
}
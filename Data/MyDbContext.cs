using EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Data
{
    public class MyDbContext(DbContextOptions<MyDbContext> options) : DbContext(options)
    {
        protected override void OnModelCreating(ModelBuilder builder) {

            builder.Entity<Books>().HasData(
                new Books {Id=1,Title="Harry potter", IsActive=true,NoOfPages=300, Description="A fictional story about a magical School." },
                new Books {Id=2,Title="Ego is Enemy", IsActive=true,NoOfPages=200, Description="Character development" },
                new Books {Id=3,Title="Obstacle is the way", IsActive=true,NoOfPages=340, Description= "Character development" },
                new Books {Id=4,Title="Raaz e Hayat", IsActive=true,NoOfPages=342, Description= "Character development" }
                
                );
            
        
        }
        public DbSet<Books> Books { get; set; }

        //public DbSet<Languages> Languages { get; set; }
    }
}

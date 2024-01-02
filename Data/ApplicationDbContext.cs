using Microsoft.EntityFrameworkCore;
using Project01.Models;

namespace Project01.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext>option) : base(option)
        {
              
        }

        //this will create a table
        public DbSet<Category> Categories { get; set; }//categories will be table name & <> with in this we need to set name of class

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //i thnk this wont need 
            modelBuilder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "action", DisplayOrder= "mk" },
                new Category { Id = 2, Name = "rmoance", DisplayOrder = "none" }
                );
        }
    }
}

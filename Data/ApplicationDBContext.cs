using Microsoft.EntityFrameworkCore;
using RepositoryApp.Models;

namespace RepositoryApp.Data
{
    
    public class ApplicationDBContext:DbContext
    {
        // managing and interacting with a database  using an
        // Object-Relational Mapping (ORM) approach

        public ApplicationDBContext(DbContextOptions<ApplicationDBContext>options):base(options)
        {
            
        }
        public DbSet<Product> Products { get; set; }

    }
}

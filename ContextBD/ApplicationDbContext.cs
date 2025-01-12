using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.ContextBD
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> contextOptions) 
            : base(contextOptions) 
        { 
        
        }

        public DbSet<Employee> Employees { get; set; }    
     
    }
}

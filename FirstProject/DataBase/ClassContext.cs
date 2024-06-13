using FirstProject.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace FirstProject.DataBase
{
    public class ClassContext:IdentityDbContext
    {
        public ClassContext(DbContextOptions<ClassContext>options):base(options) 
        {
            
        }
    
    
    
    
       public DbSet<AppUser> appUsers { get; set; }
    
    
    
    }
}

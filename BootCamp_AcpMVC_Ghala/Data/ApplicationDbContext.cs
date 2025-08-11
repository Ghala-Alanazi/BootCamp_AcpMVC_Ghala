using BootCamp_AcpMVC_Ghala.Models;
using Microsoft.EntityFrameworkCore;

namespace BootCamp_AcpMVC_Ghala.Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option):base(option) 
        { 
        
        }
            public DbSet<Category> Categories { get; set; }

        }
    }


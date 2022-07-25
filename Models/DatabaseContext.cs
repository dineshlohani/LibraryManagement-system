using Microsoft.EntityFrameworkCore;

namespace LibraryManagementSystem.Models
{
    public class DatabaseContext:DbContext
    {
        public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options)
        {

        }
        public DbSet<Addbook> Addbooks { get; set;  }
        public DbSet<Dashboard> Dashboardss { get; set; }



    }
}

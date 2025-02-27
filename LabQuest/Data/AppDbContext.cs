using Microsoft.EntityFrameworkCore;

namespace LabQuest.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // Define DbSets for your entities. For example:
        public DbSet<User> Users { get; set; }
        public DbSet<Lab> Labs { get; set; }
    }
}

using Microsoft.EntityFrameworkCore;
using LabQuest.Domain.Entities;

namespace LabQuest.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Lab> Labs { get; set; }
        public DbSet<Step> Steps { get; set; }
        public DbSet<Hint> Hints { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Lab>()
                .HasMany(l => l.Steps)
                .WithOne(s => s.Lab)
                .HasForeignKey(s => s.LabId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Step>()
                .HasMany(s => s.Hints)
                .WithOne(h => h.Step)
                .HasForeignKey(h => h.StepId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

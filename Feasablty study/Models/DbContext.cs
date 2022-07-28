using Microsoft.EntityFrameworkCore;

namespace Feasablty_study.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Feasibility_study>()
            .HasOne(a => a.Preliminary_study)
            .WithOne(a => a.feasibility_study)
            .HasForeignKey<Preliminary_study>(c => c.FeasibilityStudyId);
            modelBuilder.Entity<Feasibility_study>()
            .HasOne(a => a.market_Study)
            .WithOne(a => a.feasibility_study)
            .HasForeignKey<Market_study>(c => c.FeasibilityStudyId);
            modelBuilder.Entity<Feasibility_study>()
            .HasOne(a => a.technical_Study)
            .WithOne(a => a.feasibility_study)
            .HasForeignKey<Technical_Study>(c => c.FeasibilityStudyId);
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Support_Messages> SupportMessages { get; set; }
        public DbSet<Feasibility_study> Feasibility_studies { get; set; }
    }
}

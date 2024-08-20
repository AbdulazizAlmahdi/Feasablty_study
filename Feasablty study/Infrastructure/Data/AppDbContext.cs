using Feasablty_study.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Feasablty_study.Domin.Entites;

namespace Feasablty_study.Infrastructure.Data
{
    public class AppDbContext : IdentityDbContext<User>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Feasibility_study>()
            .HasOne(a => a.Preliminary_study)
            .WithOne(a => a.Feasibility_study)
            .HasForeignKey<Preliminary_study>(c => c.FeasibilityStudyId);
            modelBuilder.Entity<Feasibility_study>()
            .HasOne(a => a.Market_Study)
            .WithOne(a => a.Feasibility_study)
            .HasForeignKey<Market_study>(c => c.FeasibilityStudyId);
            modelBuilder.Entity<Feasibility_study>()
            .HasOne(a => a.Technical_Study)
            .WithOne(a => a.Feasibility_study)
            .HasForeignKey<Technical_Study>(c => c.FeasibilityStudyId);
            modelBuilder.Entity<User>()
                .HasMany<Support_Messages>(c => c.Messages).WithOne(u => u.User).OnDelete(DeleteBehavior.Cascade);
            modelBuilder.Entity<User>()
               .HasMany<Feasibility_study>(c => c.Feasibility_Studies).WithOne(u => u.User).OnDelete(DeleteBehavior.Cascade);


        }
        public DbSet<Support_Messages> SupportMessages { get; set; }
        public DbSet<Feasibility_study> Feasibility_studies { get; set; }
        public DbSet<Regions> Regions { get; set; }
    }
}

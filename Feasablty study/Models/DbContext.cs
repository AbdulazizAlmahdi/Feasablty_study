using Microsoft.EntityFrameworkCore;

namespace Feasablty_study.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        /*  public override void OnModelCreating(ModelBuilder modelBuilder)
          {
              modelBuilder.Entity()
              base.OnModelCreating(modelBuilder);
          }*/
        public DbSet<User> Users { get; set; }
        public DbSet<Support_Messages> SupportMessages { get; set; }
    }
}

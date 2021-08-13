using Microsoft.EntityFrameworkCore;
using SIPOS.Entities;

namespace SIPOS.Persistence
{
    public class SiposContext : DbContext
    {
        //public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=SIPOS;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<SiposUserRol>()
                .HasKey(ur => new { ur.SiposRolId, ur.SiposUserId });
        }

        public DbSet<SiposUser> SiposUser { get; set; }
        public DbSet<Product> Product { get; set; }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
    }
}

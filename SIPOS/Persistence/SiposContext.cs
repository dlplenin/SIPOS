using Microsoft.EntityFrameworkCore;
using SIPOS.Entities;
using SIPOS.Entities.Goods;
using SIPOS.Entities.User;
using SIPOS.Persistence.Seed;

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
            //modelBuilder.Entity<SiposUserRol>()
            //    .HasKey(ur => new { ur.SiposRolId, ur.SiposUserId });

            modelBuilder.Entity<SiposUser>()
                .HasIndex(su => su.UserName)
                .IsUnique();

            Seed(modelBuilder);
        }

        private void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SiposRolSeed());
        }

        public DbSet<SiposUser> SiposUser { get; set; }
        public DbSet<SiposRol> SiposRol { get; set; }
        //public DbSet<SiposUserRol> SiposUserRol { get; set; }

        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetail> OrderDetail { get; set; }
        public DbSet<Product> Product { get; set; }

        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<GoodsOrder> GoodsOrder { get; set; }
        public DbSet<GoodsOrderDetail> GoodsOrderDetail { get; set; }
    }
}

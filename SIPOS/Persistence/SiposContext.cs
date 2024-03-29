﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage;
using SIPOS.Entities;
using SIPOS.Entities.Goods;
using SIPOS.Entities.Sales;
using SIPOS.Entities.User;
using SIPOS.Persistence.Seed;

namespace SIPOS.Persistence
{
    public class SiposContext : DbContext
    {
        //public RepositoryContext(DbContextOptions<RepositoryContext> options) : base(options) { }

        private IDbContextTransaction contextTransaction;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=SIPOS;Integrated Security=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<SiposUserRol>()
            //    .HasKey(ur => new { ur.SiposRolId, ur.SiposUserId });

            modelBuilder.Entity<SiposUser>(entity =>
            {
                entity
                .HasIndex(su => su.UserName)
                .IsUnique();

                entity
                .Property(x => x.CreationDate)
                .HasDefaultValueSql("GETDATE()")
                .ValueGeneratedOnAddOrUpdate()
                .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            });
            modelBuilder.Entity<SiposRol>(entity =>
            {
                entity
                .Property(x => x.CreationDate)
                .HasDefaultValueSql("GETDATE()")
                .ValueGeneratedOnAddOrUpdate()
                .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            });

            modelBuilder.Entity<SaleOrder>(entity =>
            {
                entity
                .Property(x => x.CreationDate)
                .HasDefaultValueSql("GETDATE()")
                .ValueGeneratedOnAddOrUpdate()
                .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            });
            modelBuilder.Entity<SaleOrderDetail>(entity =>
            {
                entity
                .Property(x => x.CreationDate)
                .HasDefaultValueSql("GETDATE()")
                .ValueGeneratedOnAddOrUpdate()
                .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            });
            modelBuilder.Entity<Product>(entity =>
            {
                entity
                .Property(x => x.CreationDate)
                .HasDefaultValueSql("GETDATE()")
                .ValueGeneratedOnAddOrUpdate()
                .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            });

            modelBuilder.Entity<Supplier>(entity =>
            {
                entity
                .Property(x => x.CreationDate)
                .HasDefaultValueSql("GETDATE()")
                .ValueGeneratedOnAddOrUpdate()
                .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            });
            modelBuilder.Entity<GoodsOrder>(entity =>
            {
                entity
                .Property(x => x.CreationDate)
                .HasDefaultValueSql("GETDATE()")
                .ValueGeneratedOnAddOrUpdate()
                .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            });
            modelBuilder.Entity<GoodsOrderDetail>(entity =>
            {
                entity
                .Property(x => x.CreationDate)
                .HasDefaultValueSql("GETDATE()")
                .ValueGeneratedOnAddOrUpdate()
                .Metadata.SetAfterSaveBehavior(PropertySaveBehavior.Ignore);
            });

            Seed(modelBuilder);
        }

        private void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SiposRolSeed());
        }

        public virtual void BeginTransaction()
        {
            contextTransaction = Database.BeginTransaction();
        }

        public virtual void CommitTransaction()
        {
            try
            {
                SaveChanges();
                contextTransaction.Commit();
            }
            finally
            {
                contextTransaction.Dispose();
            }
        }

        public virtual void RollbackTransaction()
        {
            if (contextTransaction is not null)
            {
                contextTransaction.Rollback();
                contextTransaction.Dispose();
            }
        }

        public DbSet<SiposUser> SiposUser { get; set; }
        public DbSet<SiposRol> SiposRol { get; set; }

        public DbSet<SaleOrder> SaleOrder { get; set; }
        public DbSet<SaleOrderDetail> SaleOrderDetail { get; set; }
        public DbSet<Product> Product { get; set; }

        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<GoodsOrder> GoodsOrder { get; set; }
        public DbSet<GoodsOrderDetail> GoodsOrderDetail { get; set; }

    }
}

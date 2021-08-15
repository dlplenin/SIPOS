﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SIPOS.Persistence;

namespace SIPOS.Migrations
{
    [DbContext(typeof(SiposContext))]
    [Migration("20210815211446_AddGoods")]
    partial class AddGoods
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SIPOS.Entities.Order", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("SubTotal")
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("Id");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("SIPOS.Entities.OrderDetail", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<Guid>("OrderId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,4)");

                    b.Property<Guid>("ProductId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<decimal>("Total")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("Id");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetail");
                });

            modelBuilder.Entity("SIPOS.Entities.Product", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PricePurchase")
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal>("PriceSell")
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal>("SugestedPriceToSell")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("Id");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("SIPOS.Entities.User.SiposRol", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SiposRol");
                });

            modelBuilder.Entity("SIPOS.Entities.User.SiposUser", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("SiposUser");
                });

            modelBuilder.Entity("SIPOS.Entities.User.SiposUserRol", b =>
                {
                    b.Property<Guid>("SiposRolId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SiposUserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("SiposRolId", "SiposUserId");

                    b.HasIndex("SiposUserId");

                    b.ToTable("SiposUserRol");
                });

            modelBuilder.Entity("SIPOS.Entities.OrderDetail", b =>
                {
                    b.HasOne("SIPOS.Entities.Order", "Order")
                        .WithMany("OrderDetail")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SIPOS.Entities.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("SIPOS.Entities.User.SiposUserRol", b =>
                {
                    b.HasOne("SIPOS.Entities.User.SiposRol", "SiposRol")
                        .WithMany("SiposUserRol")
                        .HasForeignKey("SiposRolId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("SIPOS.Entities.User.SiposUser", "SiposUser")
                        .WithMany("SiposUserRol")
                        .HasForeignKey("SiposUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SiposRol");

                    b.Navigation("SiposUser");
                });

            modelBuilder.Entity("SIPOS.Entities.Order", b =>
                {
                    b.Navigation("OrderDetail");
                });

            modelBuilder.Entity("SIPOS.Entities.User.SiposRol", b =>
                {
                    b.Navigation("SiposUserRol");
                });

            modelBuilder.Entity("SIPOS.Entities.User.SiposUser", b =>
                {
                    b.Navigation("SiposUserRol");
                });
#pragma warning restore 612, 618
        }
    }
}
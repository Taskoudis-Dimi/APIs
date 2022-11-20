﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace SuperMarketAPI.Db
{
    public partial class smarketDbContext : DbContext
    {
        public smarketDbContext()
        {
        }

        public smarketDbContext(DbContextOptions<smarketDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<BillTbl> BillTbls { get; set; }
        public virtual DbSet<CategoryTbl> CategoryTbls { get; set; }
        public virtual DbSet<ProductTbl> ProductTbls { get; set; }
        public virtual DbSet<SellerTbl> SellerTbls { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>(entity =>
            {
                entity.Property(e => e.Street)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<BillTbl>(entity =>
            {
                entity.HasKey(e => e.BillId)
                    .HasName("PK__BillTbl__11F2FC6A86AB79DA");

                entity.ToTable("BillTbl");

                entity.Property(e => e.BillId).ValueGeneratedNever();

                entity.Property(e => e.BillDate)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SellerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CategoryTbl>(entity =>
            {
                entity.HasKey(e => e.CatId)
                    .HasName("PK__Category__6A1C8AFAA57C5496");

                entity.ToTable("CategoryTbl");

                entity.Property(e => e.CatDesc)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CatName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");
            });

            modelBuilder.Entity<ProductTbl>(entity =>
            {
                entity.HasKey(e => e.ProdId)
                    .HasName("PK__tmp_ms_x__042785E53E7C094E");

                entity.ToTable("ProductTbl");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.ProdCat)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProdName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SellerTbl>(entity =>
            {
                entity.HasKey(e => e.SellerId)
                    .HasName("PK__SellerTb__7FE3DB8139C66264");

                entity.ToTable("SellerTbl");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.SellerName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SellerPass)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SellerPhone)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Role).HasMaxLength(50);

                entity.Property(e => e.Username)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
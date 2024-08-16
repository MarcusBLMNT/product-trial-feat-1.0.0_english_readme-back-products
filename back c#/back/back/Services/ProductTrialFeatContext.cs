using System;
using System.Collections.Generic;
using back.Models;
using Microsoft.EntityFrameworkCore;

namespace back.Services;

public partial class ProductTrialFeatContext : DbContext
{
    

    public ProductTrialFeatContext()
    {
    }

    public ProductTrialFeatContext(DbContextOptions<ProductTrialFeatContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Product> Products { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.

    {

        string? host = Environment.GetEnvironmentVariable("DATABASE_CONNECTION_STRING");
        if (!string.IsNullOrEmpty(host))
        {
            optionsBuilder.UseNpgsql(host);
        }
        else
        {
            throw new Exception("Connection string undefined or wrong. Set the environment variable DATABASE_CONNECTION_STRING to Host=...;Database=...;Username=...;Password=...");
        }

    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("product_pkey");

            entity.ToTable("product");

            entity.HasIndex(e => e.Id, "pk_unique").IsUnique();

            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("id");
            entity.Property(e => e.Category)
                .HasColumnType("character varying")
                .HasColumnName("category");
            entity.Property(e => e.Code)
                .HasColumnType("character varying")
                .HasColumnName("code");
            entity.Property(e => e.Description)
                .HasDefaultValueSql("'Product Description'::character varying")
                .HasColumnType("character varying")
                .HasColumnName("description");
            entity.Property(e => e.Image)
                .HasColumnType("character varying")
                .HasColumnName("image");
            entity.Property(e => e.InventoryStatus)
                .HasColumnType("character varying")
                .HasColumnName("inventory_status");
            entity.Property(e => e.Name)
                .HasColumnType("character varying")
                .HasColumnName("name");
            entity.Property(e => e.Price).HasColumnName("price");
            entity.Property(e => e.Quantity).HasColumnName("quantity");
            entity.Property(e => e.Rating).HasColumnName("rating");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

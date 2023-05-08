using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace WinFormsCarOwners2.Models;

public partial class CarOwners2Context : DbContext
{
    public CarOwners2Context()
    {
    }

    public CarOwners2Context(DbContextOptions<CarOwners2Context> options)
        : base(options)
    {
    }

    public virtual DbSet<Brand> Brands { get; set; }

    public virtual DbSet<Car> Cars { get; set; }

    public virtual DbSet<Owner> Owners { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=CRM-UC-3355\\SQLEXPRESS;User ID=math;Password=cda1234;Database=CarOwners2;Trusted_Connection=false;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Brand>(entity =>
        {
            entity.HasKey(e => e.BrandId).HasName("PK__Brands__5E5A8E2747060D4E");

            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.BrandName)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("brand_name");
            entity.Property(e => e.BrandSlogan)
                .HasMaxLength(255)
                .IsUnicode(false)
                .HasColumnName("brand_slogan");
        });

        modelBuilder.Entity<Car>(entity =>
        {
            entity.HasKey(e => e.CarId).HasName("PK__Cars__4C9A0DB3F53425A4");

            entity.Property(e => e.CarId).HasColumnName("car_id");
            entity.Property(e => e.BrandId).HasColumnName("brand_id");
            entity.Property(e => e.CarName)
                .HasMaxLength(100)
                .IsUnicode(false)
                .HasColumnName("car_name");
            entity.Property(e => e.CarOwnerId).HasColumnName("car_owner_id");
            entity.Property(e => e.CarRegistration)
                .HasMaxLength(9)
                .IsUnicode(false)
                .IsFixedLength()
                .HasColumnName("car_registration");

            entity.HasOne(d => d.Brand).WithMany(p => p.Cars)
                .HasForeignKey(d => d.BrandId)
                .HasConstraintName("FK_brand_id");

            entity.HasOne(d => d.CarOwner).WithMany(p => p.Cars)
                .HasForeignKey(d => d.CarOwnerId)
                .HasConstraintName("FK_car_owner_id");
        });

        modelBuilder.Entity<Owner>(entity =>
        {
            entity.HasKey(e => e.OwnerId).HasName("PK__Owners__3C4FBEE4480141C4");

            entity.Property(e => e.OwnerId).HasColumnName("owner_id");
            entity.Property(e => e.OwnerFirstname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("owner_firstname");
            entity.Property(e => e.OwnerLastname)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("owner_lastname");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

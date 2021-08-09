using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Dirs21.Models
{
    public partial class Dirs21DB : DbContext
    {
        public Dirs21DB()
        {
        }

        public Dirs21DB(DbContextOptions<Dirs21DB> options)
            : base(options)
        {
        }

        public virtual DbSet<Availability> Availabilities { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Dish> Dishes { get; set; }
        public virtual DbSet<DishAvailibility> DishAvailibilities { get; set; }
        public virtual DbSet<VwMenu> VwMenus { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=.;Database=Dirs21;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Availability>(entity =>
            {
                entity.ToTable("Availability");

                entity.Property(e => e.AvailabilityId).HasColumnName("AvailabilityID");

                entity.Property(e => e.Description)
                    .HasMaxLength(20)
                    .IsFixedLength(true);
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.ToTable("Category");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName).HasMaxLength(50);
            });

            modelBuilder.Entity<Dish>(entity =>
            {
                entity.ToTable("Dish");

                entity.Property(e => e.DishId).HasColumnName("DishID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<DishAvailibility>(entity =>
            {
                entity.ToTable("Dish_Availibility");

                entity.Property(e => e.DishAvailibilityId).HasColumnName("DishAvailibilityID");

                entity.Property(e => e.AvailibilityId).HasColumnName("AvailibilityID");

                entity.Property(e => e.DishId).HasColumnName("DishID");
            });

            modelBuilder.Entity<VwMenu>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VW_Menu");

                entity.Property(e => e.Available)
                    .IsRequired()
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.Breakfast)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Category).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Dinner)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.DishId).HasColumnName("DishID");

                entity.Property(e => e.Lunch)
                    .IsRequired()
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Price)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.WaitTime)
                    .HasMaxLength(38)
                    .IsUnicode(false);

                entity.Property(e => e.WeekDay)
                    .HasMaxLength(20)
                    .IsFixedLength(true);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

using IE.Users.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace IE.Users.Infrastructure.Data
{
    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
        {
        }

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=Default");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.Id).HasName("PK__User__3214EC0703864603");

                entity.ToTable("User");

                entity.Property(e => e.Id).ValueGeneratedNever();
                entity.Property(e => e.Name).HasMaxLength(50);
                entity.Property(e => e.CreatedTime).HasColumnType("datetime");
                entity.Property(e => e.Email).HasMaxLength(50);
                entity.Property(e => e.ModifiedTime).HasColumnType("datetime");
                entity.Property(e => e.Password).HasMaxLength(50);
            });
            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

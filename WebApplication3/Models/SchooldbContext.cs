using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication3.Models
{
    public partial class SchooldbContext : DbContext
    {
        public SchooldbContext()
        {
        }

        public SchooldbContext(DbContextOptions<SchooldbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Mark> Marks { get; set; } = null!;
        public virtual DbSet<Student> Students { get; set; } = null!;

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
//#warning /To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("Data Source=AJAYDEVTS-991\\SQLEXPRESS;Initial Catalog=Schooldb;Integrated Security=True");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Mark>(entity =>
            {
                entity.HasKey(e => e.Markid)
                    .HasName("PK__Mark__8C0AC0AF535F32FF");

                entity.ToTable("Mark");

                entity.Property(e => e.Markid)
                    .ValueGeneratedNever()
                    .HasColumnName("markid");

                entity.Property(e => e.id).HasColumnName("id");

                entity.Property(e => e.Mark1).HasColumnName("mark1");

                entity.Property(e => e.Mark2).HasColumnName("mark2");

                entity.HasOne(d => d.IdNavigation)
                    .WithMany(p => p.Marks)
                    .HasForeignKey(d => d.id)
                    .HasConstraintName("fkstudent");
            });

            modelBuilder.Entity<Student>(entity =>
            {
                entity.ToTable("Student");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.std)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("std");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

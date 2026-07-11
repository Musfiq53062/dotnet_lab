using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using project2_Ums.Data.Entities;

namespace project2_Ums.Data;

public partial class UmsDbContext : DbContext
{
    public UmsDbContext()
    {
    }

    public UmsDbContext(DbContextOptions<UmsDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Faculty> Faculties { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Name=UmsDbContext");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Faculty>(entity =>
        {
            entity.ToTable("Faculty");

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Title).HasMaxLength(250);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

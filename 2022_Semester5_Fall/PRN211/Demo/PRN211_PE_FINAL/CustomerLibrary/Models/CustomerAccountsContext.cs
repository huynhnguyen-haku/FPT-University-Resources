using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace CustomerLibrary.Models;

public partial class CustomerAccountsContext : DbContext
{
    public CustomerAccountsContext()
    {
    }

    public CustomerAccountsContext(DbContextOptions<CustomerAccountsContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerAccount> CustomerAccounts { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if (!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetConnectionString("CustomerAccounts"));
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__Customer__A4AE64B890D59306");

            entity.Property(e => e.CustomerId)
                .HasMaxLength(20)
                .HasColumnName("CustomerID");
            entity.Property(e => e.CustomerDesc).HasMaxLength(250);
            entity.Property(e => e.CustomerName)
                .IsRequired()
                .HasMaxLength(80);
        });

        modelBuilder.Entity<CustomerAccount>(entity =>
        {
            entity.HasKey(e => e.AccountId).HasName("PK__Customer__349DA5865215BF3D");

            entity.Property(e => e.AccountId)
                .HasMaxLength(20)
                .HasColumnName("AccountID");
            entity.Property(e => e.AccountName)
                .IsRequired()
                .HasMaxLength(120);
            entity.Property(e => e.CustomerId)
                .HasMaxLength(20)
                .HasColumnName("CustomerID");
            entity.Property(e => e.OpenDate).HasColumnType("date");
            entity.Property(e => e.RegionName).HasMaxLength(50);

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomerAccounts)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__CustomerA__Custo__286302EC");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CCACCAA8BFB2");

            entity.Property(e => e.UserId)
                .HasMaxLength(20)
                .HasColumnName("UserID");
            entity.Property(e => e.Password)
                .IsRequired()
                .HasMaxLength(80);
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

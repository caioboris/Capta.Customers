using System;
using System.Collections.Generic;
using Capta.Customers.API.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace Capta.Customers.API.Data;

public partial class DataContext : DbContext
{
    public DataContext()
    {
    }

    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Customer> Customer { get; set; }
    public virtual DbSet<CustomerSituation> CustomerSituation { get; set; }
    public virtual DbSet<CustomerType> CustomerType { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS01;Database=master;Trusted_Connection=True;Encrypt=False");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}

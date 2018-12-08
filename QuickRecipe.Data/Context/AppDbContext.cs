using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using QuickRecipe.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace QuickRecipe.Data.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Recipe> Recipes { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Step> Steps { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Recipe>()
                .HasMany(r => r.Steps)
                .WithOne(s => s.Parent)
                .IsRequired()
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}

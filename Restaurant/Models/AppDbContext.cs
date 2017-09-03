﻿using System.Data.Entity;

namespace Restaurant.Models
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Appetizer> Appetizers { get; set; }
        public DbSet<Dessert> Desserts { get; set; }
        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Entree> Entrees { get; set; }
        public DbSet<Side> Sides { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Tax> Taxes { get; set; }
    }
}
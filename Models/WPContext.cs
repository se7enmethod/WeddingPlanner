using System;
using Microsoft.EntityFrameworkCore;

namespace WeddingPlanner.Models
{
    public class WPContext : DbContext
    {
        public WPContext(DbContextOptions options) : base(options) { }

        public DbSet<Wedding> Weddings { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Association> Associations { get; set; }
    }
}


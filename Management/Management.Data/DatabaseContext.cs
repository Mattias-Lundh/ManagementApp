using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Management.Domain.Models;

namespace Management.Data
{
    class DatabaseContext : DbContext
    {
        private string _connectionString;
        public DatabaseContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            
        }
    }
}

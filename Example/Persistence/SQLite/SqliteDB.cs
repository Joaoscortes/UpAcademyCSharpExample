using ExampleClass.Model;
using Microsoft.EntityFrameworkCore;

namespace ExampleClass.Persistence.SQLite {
    public class SqliteDB : DbContext {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder options) {
            options.UseSqlite ("Filename=db/example.db;");
        }

        protected override void OnModelCreating (ModelBuilder modelBuilder) {
            modelBuilder.Entity<Customer> ().ToTable ("Customers");
            modelBuilder.Entity<Employee> ().ToTable ("Employees");
        }
    }
}
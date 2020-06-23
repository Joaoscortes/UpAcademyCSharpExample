using ExampleClass.Model;
using Microsoft.EntityFrameworkCore;

namespace ExampleClass.Persistence.SQLite {
    public class SqliteDB : DbContext {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring (DbContextOptionsBuilder options) {
            options.UseSqlite ("Filename=db/customers.db;");
        }
    }
}
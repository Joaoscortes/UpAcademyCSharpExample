using System;
using System.Collections.Generic;
using System.Linq;
using ExampleClass.Model;
using Microsoft.Data.Sqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;

namespace ExampleClass.Persistence.SQLite {
    public class DataAccessDemo {

        public static async void TestEFC () {
            using (SqliteDB db = new SqliteDB ()) {

                var loggerFactory = db.GetService<ILoggerFactory> ();
                loggerFactory.AddProvider (new ConsoleLoggerProvider ());

                Console.WriteLine ("Inserting a new Customer");
                Console.WriteLine ("Create new Customer");
                Customer newCustomer = new Customer (
                    "sem fax",
                    "Carlos",
                    "Boss",
                    new Address ("Qualquer parte da casa", "1234567", "Lisboa"),
                    "sem telefone"
                );
                db.Add (newCustomer);
                db.SaveChanges ();

                Console.WriteLine ("Show Customers");
                List<Customer> customers = await db.Customers.ToListAsync ();
                foreach (Customer customer in customers) {
                    Console.WriteLine (customer);
                }

                Console.WriteLine ("Show Customers Ze Carlos");
                List<Customer> qc = await db.Customers.Where (customer => customer.Name == "Ze Carlos").ToListAsync ();
                foreach (Customer customer in qc) {
                    Console.WriteLine (customer);
                }
            }
        }

        public static void Test () {
            SqliteConnection db = new SqliteConnection ("Filename=db/customers.db;");

            db.Open ();

            SqliteCommand cmd = new SqliteCommand ("SELECT ContactName, ContactTitle FROM CUSTOMERS", db);

            SqliteDataReader reader = cmd.ExecuteReader ();
            while (reader.Read ()) {
                Console.WriteLine (reader.GetString (1) + " - " + reader.GetString (0));
            }

            db.Close ();
        }

        public static void TestCount () {
            SqliteConnection db = new SqliteConnection ("Filename=db/example.db;");

            db.Open ();

            SqliteCommand cmd = new SqliteCommand ("SELECT COUNT(*) FROM CUSTOMERS", db);

            SqliteDataReader reader = cmd.ExecuteReader ();
            while (reader.Read ()) {
                int count;
                int.TryParse (reader.GetString (0), out count);
                Console.WriteLine (count);
            }

            db.Close ();
        }
    }
}
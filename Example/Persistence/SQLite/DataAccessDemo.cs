using System;
using ExampleClass.Model;
using Microsoft.Data.Sqlite;

namespace ExampleClass.Persistence.SQLite {
    public class DataAccessDemo {

        public static void TestEFC () {
            using (SqliteDB db = new SqliteDB ()) {
                var customers = db.Customers;

                foreach (Customer customer in customers) {
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
    }
}
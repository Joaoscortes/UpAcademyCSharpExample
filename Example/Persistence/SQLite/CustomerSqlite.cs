using ExampleClass.Model;

namespace ExampleClass.Persistence.SQLite {
    public class CustomerSqlite : BaseSqlite<Customer> {

        public CustomerSqlite () {
            dbEntity = db.Customers;
        }
    }
}
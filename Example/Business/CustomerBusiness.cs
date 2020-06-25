using ExampleClass.Model;
using ExampleClass.Persistence.List;
using ExampleClass.Persistence.SQLite;

namespace ExampleClass.Business {
    public class CustomerBusiness : BaseBusiness<Customer, PersistenceBase<Customer>> {

        public CustomerBusiness (string type) {
            switch (type.ToLower ()) {
                case "1":
                case "local":
                case "list":
                    System.Console.WriteLine ("Using Local List");
                    database = CustomerList.Instance;
                    break;
                default:
                    System.Console.WriteLine ("Using Sqlite");
                    database = new CustomerSqlite ();
                    break;
            }
        }
    }
}
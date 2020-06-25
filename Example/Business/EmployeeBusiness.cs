using ExampleClass.Model;
using ExampleClass.Persistence.List;
using ExampleClass.Persistence.SQLite;

namespace ExampleClass.Business {
    public class EmployeeBusiness : BaseBusiness<Employee, PersistenceBase<Employee>> {

        public EmployeeBusiness (string type) {
            switch (type.ToLower ()) {
                case "1":
                case "local":
                case "list":
                    System.Console.WriteLine ("Using Local List");
                    database = EmployeeList.Instance;
                    break;
                default:
                    System.Console.WriteLine ("Using Sqlite");
                    database = new EmployeeSqlite ();
                    break;
            }
        }
    }
}
using ExampleClass.Model;

namespace ExampleClass.Persistence.SQLite {
    public class EmployeeSqlite : BaseSqlite<Employee> {
        public EmployeeSqlite () {
            dbEntity = db.Employees;
        }
    }
}
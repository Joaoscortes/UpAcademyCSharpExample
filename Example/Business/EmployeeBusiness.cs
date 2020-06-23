using ExampleClass.Model;
using ExampleClass.Persistence.List;

namespace ExampleClass.Business {
    public class EmployeeBusiness : BaseBusiness<Employee, PersistenceBase<Employee>> {

        public EmployeeBusiness () {
            database = EmployeeList.Instance;
        }
    }
}
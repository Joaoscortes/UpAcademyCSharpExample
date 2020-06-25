using ExampleClass.Business;
using ExampleClass.Model;

namespace ExampleClass.Presentation {
    public class EmployeeMenu : CRUDMenu<Employee, EmployeeBusiness, PersistenceBase<Employee>> {

        public EmployeeMenu (string databaseType) {
            this.className = "Employee";
            business = new EmployeeBusiness (databaseType);
        }

        public override void AddMenu () {
            // TODO - Console logic to get Employee values
            Employee employee = new Employee (
                "",
                "01/08/2018",
                "sem photo",
                "Ze Manel",
                "Boss",
                new Address ("Toda a casa", "1234567", "Lisboa"),
                "sem telefone"
            );
            business.Add (employee);
        }
    }
}
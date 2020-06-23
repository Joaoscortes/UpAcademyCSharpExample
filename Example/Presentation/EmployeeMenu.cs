using ExampleClass.Business;
using ExampleClass.Model;
using ExampleClass.Persistence;
using ExampleClass.Persistence.List;

namespace ExampleClass.Presentation {
    public class EmployeeMenu : CRUDMenu<Employee, EmployeeBusiness, PersistenceBase<Employee>> {

        public EmployeeMenu () {
            this.className = "Employee";
            business = new EmployeeBusiness ();
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
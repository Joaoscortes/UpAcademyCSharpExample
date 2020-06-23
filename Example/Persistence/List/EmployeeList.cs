using ExampleClass.Model;

namespace ExampleClass.Persistence.List {

    public sealed class EmployeeList : BaseList<Employee> {
        private static EmployeeList instance = null;
        private static readonly object padlock = new object ();
        EmployeeList () { }

        public static EmployeeList Instance {
            get {
                lock (padlock) {
                    if (instance == null) {
                        instance = new EmployeeList ();
                    }
                    return instance;
                }
            }
        }

    }
}
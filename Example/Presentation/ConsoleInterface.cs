using System;
using ExampleClass.Business;
using ExampleClass.Model;

namespace ExampleClass.Presentation {
    public class ConsoleInterface {
        CRUDMenu<Customer, CustomerBusiness, PersistenceBase<Customer>> MenuCustomers = new CustomerMenu ();
        CRUDMenu<Employee, EmployeeBusiness, PersistenceBase<Employee>> MenuEmployees = new EmployeeMenu ();
        public void MenuInit () {
            string input = "";
            do {
                Console.WriteLine ("Menu Inicial");
                Console.WriteLine ("Opção 1 - Menu Customers");
                Console.WriteLine ("Opção 2 - Menu Employees");
                Console.WriteLine ("Opção 0 - Sair");
                input = Console.ReadLine ();
                switch (input) {
                    case "0":
                        return;
                    case "1":
                        MenuCustomers.MainMenu ();
                        break;
                    case "2":
                        MenuEmployees.MainMenu ();
                        break;
                    default:
                        Console.WriteLine ("Opções Validas - ( 1 , 2 , 0 )");
                        break;
                }
            } while (true);
        }
    }
}
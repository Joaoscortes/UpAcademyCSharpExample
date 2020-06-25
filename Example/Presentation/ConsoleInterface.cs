using System;
using ExampleClass.Business;
using ExampleClass.Model;

namespace ExampleClass.Presentation {
    public class ConsoleInterface {
        CRUDMenu<Customer, CustomerBusiness, PersistenceBase<Customer>> MenuCustomers;
        CRUDMenu<Employee, EmployeeBusiness, PersistenceBase<Employee>> MenuEmployees;

        public ConsoleInterface () {
            ChangeDataBase ();

        }
        public void MenuInit () {
            string input = "";
            do {
                Console.WriteLine ("Menu Inicial");
                Console.WriteLine ("Opção 1 - Menu Customers");
                Console.WriteLine ("Opção 2 - Menu Employees");
                Console.WriteLine ("Opção 3 - Change Database");
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
                    case "3":
                        ChangeDataBase ();
                        break;
                    default:
                        Console.WriteLine ("Opções Validas - ( 1 , 2 , 3 , 0 )");
                        break;
                }
            } while (true);
        }

        public void ChangeDataBase () {
            Console.WriteLine ("Select Persistence");
            Console.WriteLine ("Opção - 1 \"List\" / \"Local\" ");
            Console.WriteLine ("Opção - 2 \"Sqlite\" / \"\" - (Default)");
            string optionPersistence = Console.ReadLine ();
            MenuCustomers = new CustomerMenu (optionPersistence);
            MenuEmployees = new EmployeeMenu (optionPersistence);
        }
    }
}
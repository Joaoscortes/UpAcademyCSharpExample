using System;
using ExampleClass.Business;
using ExampleClass.Model;
using ExampleClass.Persistence;

namespace ExampleClass.Presentation {
    public abstract class CRUDMenu<T, U, V> where T : Person where U : BaseBusiness<T, V> where V : PersistenceBase<T> {
        protected string className;
        protected U business;

        public void MainMenu () {
            string input = "";
            do {
                Console.WriteLine ($"Menu {className}'s - {business.Count()}");
                Console.WriteLine ($"opção 1 - Add {className}");
                if (business.Count () > 0) {
                    Console.WriteLine ($"opção 2 - Remove {className}");
                    Console.WriteLine ($"opção 3 - Update {className}");
                    Console.WriteLine ($"opção 4 - View {className}");
                }
                Console.WriteLine ($"opção 0 - Menu Init");
                input = Console.ReadLine ();
                switch (input) {
                    case "1":
                        AddMenu ();
                        break;
                    case "2":
                        if (business.Count () > 0) {
                            // TODO - Method to Remove
                            Console.WriteLine ("TODO - removeEntity ()");
                        }
                        break;
                    case "3":
                        if (business.Count () > 0) {
                            // TODO - Method to Update
                            Console.WriteLine ("TODO - updateCustomer ()");
                        }
                        break;
                    case "4":
                        if (business.Count () > 0) {
                            showAll ();
                        }
                        break;
                    case "0":
                        return;
                }
            } while (true);
        }

        public abstract void AddMenu ();

        private void showAll () {
            Console.WriteLine ("--------------------------------------");
            Console.WriteLine ("-----------------List-----------------");
            Console.WriteLine ("--------------------------------------");
            foreach (var item in business.GetAll ()) {
                Console.WriteLine (item);
                Console.WriteLine ("--------------------------------------");
            }
            Console.WriteLine ("---------------End  List--------------");
            Console.WriteLine ("--------------------------------------");
        }
    }
}
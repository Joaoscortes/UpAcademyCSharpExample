using ExampleClass.Persistence.SQLite;
using ExampleClass.Presentation;

namespace ExampleClass {
    class Program {
        static void Main (string[] args) {
            ConsoleInterface app = new ConsoleInterface ();
            app.MenuInit ();
            // DataAccessDemo.Test ();
        }
    }
}
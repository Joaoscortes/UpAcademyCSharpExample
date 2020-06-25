using System;
using ExampleClass.Model;
using ExampleClass.Presentation;

namespace ExampleClass {
    class Program {
        static void Main (string[] args) {
            ConsoleInterface app = new ConsoleInterface ();
            app.MenuInit ();

            // DataAccessDemo.Test ();
            // DataAccessDemo.TestEFC ();
            // DataAccessDemo.TestEFC ();
            // DataAccessDemo.TestCount ();

            // TestAttributeByAtributeName ();

            // TestStringToDateTime ();
        }

        private static void TestAttributeByAtributeName () {
            Customer c = new Customer (
                "sem fax",
                "Ze Manel",
                "Boss",
                new Address ("Toda a casa", "1234567", "Lisboa"),
                "sem telefone"
            );

            Console.WriteLine (c);
            Console.WriteLine ("-----> Name from GetPropertyValue  : " + c.GetPropertyValue ("Name"));
            Console.WriteLine ("-----> Fax from GetPropertyValue  : " + c.GetPropertyValue ("Fax"));
            c.GetType ().GetProperty ("Name").SetValue (c, "Atum");
            Console.WriteLine (c);
            Console.WriteLine ("-----> Name : " + c.GetType ().GetProperty ("Name").GetValue (c, null));
        }

        private static void TestStringToDateTime () {
            Console.WriteLine (Helper.StringToDateTime ("01/10/1200"));
            Console.WriteLine (Helper.StringToDateTime ("02,04,2020"));
            Console.WriteLine (Helper.StringToDateTime ("03 12 1500"));
        }
    }
}
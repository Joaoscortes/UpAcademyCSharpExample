using System;
using GenericExample.Model;

// https://www.tutorialsteacher.com/csharp/csharp-generics
namespace GenericExample {
    class Program {
        ClassAList classAList = new ClassAList ();
        ClassBList classBList = new ClassBList ();

        GenericMyList<ClassA> genericClassA = new GenericMyList<ClassA> ();
        GenericMyList<ClassB> genericClassB = new GenericMyList<ClassB> ();

        ClassAListFromGeneric classAListFromGeneric = new ClassAListFromGeneric ();
        ClassBListFromGeneric classBListFromGeneric = new ClassBListFromGeneric ();

        static void Main (string[] args) {
            Program app = new Program ();
            app.Start ();
        }

        private void Start () {
            classAList.Add (new ClassA () { Value = 1 });
            classAList.Add (new ClassA () { Value = 2 });
            classAList.Add (new ClassA () { Value = 3 });
            Console.WriteLine ("ClassA List --->");
            Console.WriteLine (classAList.Count ());
            classAList.PrintList ();
            Console.WriteLine ("<--- ClassA List");

            genericClassA.Add (new ClassA () { Value = 1 });
            genericClassA.Add (new ClassA () { Value = 2 });
            genericClassA.Add (new ClassA () { Value = 3 });
            Console.WriteLine ("Generic ClassA List --->");
            Console.WriteLine (genericClassA.Count ());
            genericClassA.PrintList ();
            Console.WriteLine ("<--- Generic ClassA List");

            classAListFromGeneric.Add (new ClassA () { Value = 1 });
            classAListFromGeneric.Add (new ClassA () { Value = 2 });
            classAListFromGeneric.Add (new ClassA () { Value = 3 });
            Console.WriteLine ("ClassA List From Generic --->");
            Console.WriteLine (classAListFromGeneric.Count ());
            classAListFromGeneric.PrintList ();
            Console.WriteLine ("<--- ClassA List From Generic");

            classBList.Add (new ClassB () { Value = "1" });
            classBList.Add (new ClassB () { Value = "2" });
            classBList.Add (new ClassB () { Value = "3" });
            Console.WriteLine ("ClassB List --->");
            Console.WriteLine (classBList.Count ());
            classBList.PrintList ();
            Console.WriteLine ("<--- ClassB List");

            genericClassB.Add (new ClassB () { Value = "1" });
            genericClassB.Add (new ClassB () { Value = "2" });
            genericClassB.Add (new ClassB () { Value = "3" });
            Console.WriteLine ("Generic ClassB List --->");
            Console.WriteLine (genericClassB.Count ());
            genericClassB.PrintList ();
            Console.WriteLine ("<--- Generic ClassB List");

            classBListFromGeneric.Add (new ClassB () { Value = "1" });
            classBListFromGeneric.Add (new ClassB () { Value = "2" });
            classBListFromGeneric.Add (new ClassB () { Value = "3" });
            Console.WriteLine ("ClassB List From Generic --->");
            Console.WriteLine (classBListFromGeneric.Count ());
            classBListFromGeneric.PrintList ();
            Console.WriteLine ("<--- ClassB List From Generic");
        }
    }
}
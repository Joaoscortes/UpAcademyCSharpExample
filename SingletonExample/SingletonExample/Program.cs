using System;
using SingletonExample.Model;

namespace SingletonExample {
    class Program {
        static void Main (string[] args) {
            Program app = new Program ();
            app.Start ();
        }

        private void Start () {
            ClassA ca = new ClassA ();
            ClassB cb = new ClassB ();

            ca.Add (1);
            cb.Add (2);
            ca.Add (3);
            cb.Add (4);
            ca.Add (5);

            Console.WriteLine ("Class A Count");
            Console.WriteLine (ca.Count ());
            Console.WriteLine ("Class B Count");
            Console.WriteLine (cb.Count ());
        }
    }
}
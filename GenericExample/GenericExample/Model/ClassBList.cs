using System;
using System.Collections.Generic;

namespace GenericExample.Model {
    public class ClassBList {
        private List<ClassB> myList = new List<ClassB> ();

        public List<ClassB> GetAll () {
            return myList;
        }
        public void Add (ClassB element) {
            myList.Add (element);
        }

        public void Remove (ClassB element) {
            myList.Remove (element);
        }

        public int Count () {
            return myList.Count;
        }

        public void PrintList () {
            foreach (ClassB item in myList) {
                Console.WriteLine ($"Item - {item}");
            }
        }
    }
}
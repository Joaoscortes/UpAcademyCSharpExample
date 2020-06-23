using System;
using System.Collections.Generic;

namespace GenericExample.Model {

    public class ClassAList {
        private List<ClassA> myList = new List<ClassA> ();

        public List<ClassA> GetAll () {
            return myList;
        }
        public void Add (ClassA element) {
            myList.Add (element);
        }

        public void Remove (ClassA element) {
            myList.Remove (element);
        }

        public int Count () {
            return myList.Count;
        }

        public void PrintList () {
            foreach (ClassA item in myList) {
                Console.WriteLine ($"Item - {item}");
            }
        }
    }
}
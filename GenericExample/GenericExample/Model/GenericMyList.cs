using System;
using System.Collections.Generic;

namespace GenericExample.Model {
    public class GenericMyList<T> {
        private List<T> myList = new List<T> ();

        public List<T> GetAll () {
            return myList;
        }
        public void Add (T element) {
            myList.Add (element);
        }

        public void Remove (T element) {
            myList.Remove (element);
        }

        public int Count () {
            return myList.Count;
        }

        public void PrintList () {
            foreach (T item in myList) {
                Console.WriteLine ($"Item - {item}");
            }
        }

    }
}
using System;
using System.Collections.Generic;

namespace SingletonExample.Model {
    // https://www.c-sharpcorner.com/UploadFile/8911c4/singleton-design-pattern-in-C-Sharp/
    public sealed class SingletonList {
        private SingletonList () { }
        private static readonly Lazy<SingletonList> lazy = new Lazy<SingletonList> (() => new SingletonList ());
        public static SingletonList Instance {
            get {
                return lazy.Value;
            }
        }

        private List<int> list = new List<int> ();

        public void Add (int number) {
            list.Add (number);
        }

        public int Count () {
            return list.Count;
        }
    }
}
using System.Collections.Generic;

namespace SingletonExample.Model {
    public class MyList {
        private List<int> list = new List<int> ();

        public void Add (int number) {
            list.Add (number);
        }

        public int Count () {
            return list.Count;
        }
    }
}
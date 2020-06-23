namespace SingletonExample.Model {
    public class ClassA {
        private SingletonList sl = SingletonList.Instance;
        private MyList l = new MyList ();

        public void Add (int number) {
            sl.Add (number);
            l.Add (number);
        }

        public string Count () {
            return $"Singleton Count : {sl.Count ()} - List : {l.Count ()}";
        }
    }
}
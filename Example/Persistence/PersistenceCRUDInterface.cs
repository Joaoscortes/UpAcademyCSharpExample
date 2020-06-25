using System.Collections.Generic;

namespace ExampleClass.Model {
    public interface PersistenceCRUDInterface<T> where T : Person {
        public void Add (T obj);

        public List<T> GetAll ();

        public void Remove (T obj);
    }
}
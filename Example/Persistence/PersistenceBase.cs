using System.Collections.Generic;
using ExampleClass.Model;

namespace ExampleClass.Persistence {
    public abstract class PersistenceBase<T> : PersistenceCRUDInterface<T> where T : Person {
        public abstract void Add (T customer);

        public abstract void Remove (T customer);

        public abstract void RemoveByName (string name);

        public abstract T FindByName (string name);

        public abstract List<T> GetAll ();

        public abstract int Count ();
    }
}
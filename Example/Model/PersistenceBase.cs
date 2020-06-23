using System.Collections.Generic;

namespace ExampleClass.Model {
    public abstract class PersistenceBase<T> : PersistenceCRUDInterface<T> where T : Person {
        public abstract void Add (T entity);

        public abstract void Remove (T entity);

        public abstract void RemoveByName (string name);

        public abstract T FindByName (string name);

        public abstract List<T> GetAll ();

        public abstract int Count ();
    }
}
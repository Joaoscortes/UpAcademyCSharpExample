using System.Collections.Generic;

namespace ExampleClass.Model {
    public abstract class BaseBusiness<T, U> where T : Person where U : PersistenceBase<T> {
        protected U database;

        public void Add (T entity) {
            database.Add (entity);
        }

        public void Remove (T entity) {
            database.Remove (entity);
        }

        public List<T> GetAll () {
            return database.GetAll ();
        }

        public int Count () {
            return database.Count ();
        }
    }
}
using System.Collections.Generic;
using ExampleClass.Model;
using ExampleClass.Persistence;

namespace ExampleClass.Business {
    public abstract class BaseBusiness<T, U> where T : Person where U : PersistenceBase<T> {
        protected U database;

        public void Add (T entity) {
            database.Add (entity);
        }

        public void Remove (T entity) {
            database.Remove (entity);
        }

        public void RemoveByName (string name) {
            database.RemoveByName (name);
        }

        public T FindByName (string name) {
            return database.FindByName (name);
        }

        public List<T> GetAll () {
            return database.GetAll ();
        }

        public int Count () {
            return database.Count ();
        }
    }
}
using System;
using System.Collections.Generic;
using ExampleClass.Model;

namespace ExampleClass.Persistence.List {

    public abstract class BaseList<T> : PersistenceBase<T> where T : Person {
        private List<T> db = new List<T> ();

        public override void Add (T entity) {
            db.Add (entity);
        }

        public override void Remove (T entity) {
            db.Remove (entity);
        }

        public override void RemoveByName (string name) {
            //  TODO - List remove by name attr
            Console.WriteLine ("RemoveByName");
            // db.Remove (name);
        }

        public override T FindByName (string name) {
            return db.Find (entity => entity.Name == name);
        }

        public override List<T> GetAll () {
            return db;
        }

        public override int Count () {
            return db.Count;
        }
    }
}
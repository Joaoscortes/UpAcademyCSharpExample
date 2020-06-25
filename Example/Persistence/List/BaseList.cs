using System.Collections.Generic;

namespace ExampleClass.Model {

    public abstract class BaseList<T> : PersistenceBase<T> where T : Person {
        private List<T> db = new List<T> ();

        public override void Add (T entity) {
            db.Add (entity);
        }

        public override void Remove (T entity) {
            db.Remove (entity);
        }

        public override List<T> GetAll () {
            return db;
        }

        public override int Count () {
            return db.Count;
        }
    }
}
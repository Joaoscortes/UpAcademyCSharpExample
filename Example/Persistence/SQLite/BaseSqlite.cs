using System.Collections.Generic;
using System.Linq;
using ExampleClass.Persistence.SQLite;
using Microsoft.EntityFrameworkCore;

namespace ExampleClass.Model {
    public abstract class BaseSqlite<T> : PersistenceBase<T> where T : Person {
        protected SqliteDB db = new SqliteDB ();
        protected DbSet<T> dbEntity;

        public override List<T> GetAll () {
            return dbEntity.ToList ();
        }

        public override void Add (T entity) {
            db.Add (entity);
            db.SaveChanges ();
        }

        public override void Remove (T entity) {
            db.Remove (entity);
            db.SaveChanges ();
        }

        public override int Count () {
            return dbEntity.Count ();
        }
    }
}
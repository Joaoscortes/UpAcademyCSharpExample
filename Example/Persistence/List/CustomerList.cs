using ExampleClass.Model;

// https://csharpindepth.com/articles/singleton
namespace ExampleClass.Persistence.List {

    public sealed class CustomerList : BaseList<Customer> {
        private static CustomerList instance = null;
        private static readonly object padlock = new object ();
        CustomerList () { }

        public static CustomerList Instance {
            get {
                lock (padlock) {
                    if (instance == null) {
                        instance = new CustomerList ();
                    }
                    return instance;
                }
            }
        }
    }
}
using ExampleClass.Model;
using ExampleClass.Persistence.List;

namespace ExampleClass.Business {
    public class CustomerBusiness : BaseBusiness<Customer, PersistenceBase<Customer>> {

        public CustomerBusiness () {
            database = CustomerList.Instance;
        }

    }
}
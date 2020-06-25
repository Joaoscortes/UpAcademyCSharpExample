using ExampleClass.Business;
using ExampleClass.Model;

namespace ExampleClass.Presentation {
    public class CustomerMenu : CRUDMenu<Customer, CustomerBusiness, PersistenceBase<Customer>> {

        public CustomerMenu (string databaseType) {
            this.className = "Customer";
            business = new CustomerBusiness (databaseType);
        }

        public override void AddMenu () {
            // TODO - Console logic to get Customer values
            Customer customer = new Customer (
                "sem fax",
                "Ze Manel",
                "Boss",
                new Address ("Toda a casa", "1234567", "Lisboa"),
                "sem telefone"
            );
            business.Add (customer);
        }
    }
}
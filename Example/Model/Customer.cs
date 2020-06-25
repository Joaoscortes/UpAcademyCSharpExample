namespace ExampleClass.Model {
    public class Customer : Person {
        public string Fax { get; set; }

        public Customer () { }
        public Customer (string fax, string name, string title, Address address, string homePhone) : base (name, title, address, homePhone) {
            Fax = fax;
        }

        public override string ToString () {
            return $"\tCustomer Details\n{base.ToString()}\nFax - {Fax}";
        }
    }
}
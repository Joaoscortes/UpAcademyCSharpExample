namespace ExampleClass.Model {
    public class Address {
        public string _Address { get; set; }
        public string Code { get; set; }
        public string City { get; set; }

        public Address (string address, string code, string city) {
            _Address = address;
            Code = code;
            City = city;
        }

        public override string ToString () {
            return $"Address - {_Address}\n\tCode - {Code}\n\tCity - {City}";
        }
    }
}
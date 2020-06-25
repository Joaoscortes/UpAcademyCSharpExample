using System.ComponentModel.DataAnnotations;
// https://www.newtonsoft.com/json/help/html/N_Newtonsoft_Json.htm
using Newtonsoft.Json;

namespace ExampleClass.Model {
    public abstract class Person {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public Address Address { get; set; }
        public string HomePhone { get; set; }

        public Person () { }
        public Person (string name, string title, Address address, string homePhone) {
            Name = name;
            Title = title;
            Address = address;
            HomePhone = homePhone;
        }

        public static string PersonToJson (Person person) {
            return JsonConvert.SerializeObject (person, Formatting.Indented);
        }

        public static Person JsonToPerson (string json) {
            return JsonConvert.DeserializeObject<Customer> (json);
        }

        public override string ToString () {
            return $"Name - {Name}\nTitle - {Title}\nAddress - {Address}\nHomePhone - {HomePhone}";
        }
    }
}
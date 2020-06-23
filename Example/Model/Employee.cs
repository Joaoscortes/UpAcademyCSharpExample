namespace ExampleClass.Model {
    public class Employee : Person {
        public string TitleCourtesy { get; set; }
        // TODO - Change BirthDate property to DateTime type
        public string BirthDate { get; set; }
        public string Photo { get; set; }

        public Employee (string titleCourtesy, string birthDate, string photo, string name, string title, Address address, string homePhone) : base (name, title, address, homePhone) {
            TitleCourtesy = titleCourtesy;
            BirthDate = birthDate;
            Photo = photo;
        }

        public override string ToString () {
            return $"\tEmployee Details\n{base.ToString()}\nTitleCourtesy - {TitleCourtesy}\nBirthDate - {BirthDate}\nPhoto - {Photo}";
        }
    }
}
namespace GenericExample.Model {
    public class ClassA {
        public int Value { get; set; }

        public override string ToString () {
            return $"{Value}";
        }
    }
}
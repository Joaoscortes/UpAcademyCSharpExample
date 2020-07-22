using System;

namespace DynamicTest {
  class Program {
    static void Main (string[] args) {
      dynamic person = new DynamicDictionary ();

      person.Name = "Ellen";
      person.Email = "Adams";
      person.Contact = 987654321;

      Console.WriteLine (person.Name + " " + person.Email + " " + person.Contact);

      Console.WriteLine (
        "Number of dynamic properties:" + person.Count);

    }
  }
}
using System;
using Desafio5Lib;

namespace Runner {
    class Program {
        static void Main (string[] args) {
            int count = Desafio5.countDays ("01/01/2019", "01/02/2019");
            Console.WriteLine ($"Count - {count}");
        }
    }
}
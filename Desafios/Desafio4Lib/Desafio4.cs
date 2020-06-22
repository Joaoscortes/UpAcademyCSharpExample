using System;
using System.Collections.Generic;

namespace Desafio4Lib {
    public class Desafio4 {
        public static int[] ints (string msg) {
            string[] values = msg.Split (' ');
            List<int> result = new List<int> ();

            foreach (string value in values) {
                int number;
                bool isNumber;
                isNumber = int.TryParse (value, out number);
                if (isNumber) {
                    result.Add (number);
                }
            }

            return result.ToArray ();
        }

    }
}
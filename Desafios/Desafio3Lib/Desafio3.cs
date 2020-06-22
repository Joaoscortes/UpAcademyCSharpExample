using System;

namespace Desafio3Lib {
    public class Desafio3 {
        public static int points (string[] values, bool allHome) {
            // if (!allHome) {
            //     values = resolveValues (values);
            // }
            // return resAllHome (values);

            return res (values, allHome);
        }

        private static int resAllHome (string[] values) {
            int result = 0;
            foreach (string value in values) {
                result += (value[0] > value[2]) ? 3 : (value[0] == value[2]) ? 1 : 0;
            }
            return result;
        }

        private static string[] resolveValues (string[] values) {
            for (int i = 0; i < values.Length; i++) {
                if (i % 2 == 0) {
                    values[i] = values[i][2] + ":" + values[i][0];
                }
            }
            return values;
        }

        private static int res (string[] values, bool home) {
            int result = 0;
            for (int i = 0; i < values.Length; i++) {
                string a = values[i];
                char left = a[0];
                char right = a[2];
                if (!home && i % 2 == 0) {
                    left = a[2];
                    right = a[0];
                }
                result += (left > right) ? 3 : (a[0] == a[2]) ? 1 : 0;
            }
            return result;
        }
    }
}
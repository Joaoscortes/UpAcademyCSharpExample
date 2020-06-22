using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Desafio5Lib {
    public class Desafio5 {
        public static double countDays (string init, string end) {
            // return resolution (init, end);
            return resolution1 (init, end);
            // return resolution2 (init, end);
        }

        private static double resolution (string init, string end) {
            DateTime initDate;
            DateTime endDate;
            try {
                string initAfterRegex = string.Join ("/", regexStringToStringArray (init));
                string endAfterRegex = string.Join ("/", regexStringToStringArray (end));

                initDate = DateTime.ParseExact (initAfterRegex, "dd/MM/yyyy", CultureInfo.InvariantCulture);
                endDate = DateTime.ParseExact (endAfterRegex, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            } catch (System.Exception) {
                throw new InvalidOperationException ("Invalid Date.");
            }

            return (endDate - initDate).TotalDays;
        }

        private static double resolution1 (string init, string end) {
            double count = 0;
            double[] initArray = convertStringArrayToDoubleArray (regexStringToStringArray (init));
            double[] endArray = convertStringArrayToDoubleArray (regexStringToStringArray (end));
            if (initArray.Length != 3 || endArray.Length != 3) {
                throw new InvalidOperationException ("Invalid Date.");
            }

            // Add Days
            count += (endArray[0] - initArray[0]);

            // Convert moths to days and add Days
            if (initArray[1] <= endArray[1]) {
                for (double i = initArray[1]; i < endArray[1]; i++) {
                    count += getDaysInMonth (i, endArray[2]);
                }
            } else {
                for (double i = initArray[1] - 1; i >= endArray[1]; i--) {
                    count -= getDaysInMonth (i, initArray[2]);
                }
            }

            // Convert years to days and add Days
            bool isInitBig = false;
            if (initArray[2] > endArray[2]) {
                isInitBig = true;
                double tempYear = initArray[2];
                initArray[2] = endArray[2];
                endArray[2] = tempYear;
            }
            for (double i = initArray[2]; i < endArray[2]; i++) {
                count += isLeapYear (i) ? 366 : 365;
            }
            return isInitBig? 0 - count : count;
        }

        public static int resolution2 (string value1, string value2) {
            List<int> initDate = stringArrayToListInt (stringToStringArray (value1));
            List<int> endDate = stringArrayToListInt (stringToStringArray (value2));

            if (initDate.Count != 3 || endDate.Count != 3) {
                throw new InvalidOperationException ("Invalid Date.");
            }
            int result = differenceDays (initDate[0], endDate[0]);
            result += differenceMonths (initDate[1], endDate[1], initDate[2]);
            result += differenceYears (initDate[2], endDate[2]);

            return result;
        }

        public static double[] dateStringToDoubleArray (string msg) {
            string[] values = msg.Split ('/');
            List<double> result = new List<double> { };

            foreach (string value in values) {
                if (double.TryParse (value, out double number)) {
                    result.Add (number);
                }
            }

            return result.ToArray ();
        }

        public static string[] regexStringToStringArray (string msg) {
            MatchCollection matchCol = Regex.Matches (msg, @"\d+");
            string[] strArray = new string[matchCol.Count];
            for (int i = 0; i < matchCol.Count; i++) {
                strArray[i] = matchCol[i].Groups[0].Value;
            }
            return strArray;
        }

        public static double[] convertStringArrayToDoubleArray (string[] stringArray) {
            return Array.ConvertAll (stringArray, s => double.TryParse (s, out var i) ? i : throw new InvalidOperationException ("Invalid Date."));
        }

        public static double[] convertStringToDoubleArray (string msg) {
            return convertStringArrayToDoubleArray (regexStringToStringArray (msg));
        }

        public static string[] stringToStringArray (string msg) {
            List<string> resultList = new List<string> ();

            for (int i = 0; i < msg.Length; i++) {
                if (Char.IsDigit (msg[i])) {
                    int init = i;
                    do {
                        if (i < msg.Length) {
                            i++;
                        }
                    } while (i < msg.Length && Char.IsDigit (msg[i]));
                    resultList.Add (msg.Substring (init, i - init));
                }
            }

            return resultList.ToArray ();
        }

        public static List<int> stringArrayToListInt (string[] values) {
            List<int> result = new List<int> ();

            foreach (string stringNumber in values) {
                int number;
                if (int.TryParse (stringNumber, out number)) {
                    result.Add (number);
                }
            }

            return result;
        }

        public static int differenceDays (int initDay, int endDay) {
            return endDay - initDay;
        }

        public static int getDaysInMonth (int month, int year) {
            switch (month) {
                case 4:
                case 6:
                case 9:
                case 11:
                    return 30;
                case 2:
                    return isLeapYear (year) ? 29 : 28;
                default:
                    return 31;
            }
        }

        public static double getDaysInMonth (double month, double year) {
            double result = 0;

            switch (month) {
                case 4:
                case 6:
                case 9:
                case 11:
                    result = 30;
                    break;
                case 2:
                    result = isLeapYear (year) ? 29 : 28;
                    break;
                default:
                    result = 31;
                    break;
            }

            return result;
        }

        public static int differenceMonths (int initMonth, int endMonth, int year) {
            int countM = 0;

            if (initMonth <= endMonth) {
                for (int i = initMonth; i < endMonth; i++) {
                    countM += getDaysInMonth (i, year);
                }
            } else {
                for (int i = initMonth - 1; i >= endMonth; i--) {
                    countM -= getDaysInMonth (i, year);
                }
            }

            return countM;
        }

        public static int differenceYears (int initYear, int endYear) {
            int countY = 0;
            bool isInitBig = false;

            if (initYear > endYear) {
                isInitBig = true;
                int temp = initYear;
                initYear = endYear;
                endYear = temp;
            }

            for (int i = initYear; i < endYear; i++) {
                countY = isLeapYear (i) ? 366 : 365;
            }

            return isInitBig? 0 - countY : countY;
        }

        public static bool isLeapYear (int year) {
            return (year % 400 == 0 || year % 100 != 0 && year % 4 == 0) ? true : false;
        }

        public static bool isLeapYear (double year) {
            return (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)) ? true : false;
        }

    }

}
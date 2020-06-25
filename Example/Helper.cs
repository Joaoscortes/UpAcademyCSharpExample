using System;
using System.Globalization;
using System.Text.RegularExpressions;

namespace ExampleClass {
    public static class Helper {
        public static object GetPropertyValue (this object T, string PropName) {
            return T.GetType ().GetProperty (PropName) == null ? null : T.GetType ().GetProperty (PropName).GetValue (T, null);
        }

        public static DateTime StringToDateTime (string init) {
            DateTime initDate;
            try {
                string initAfterRegex = string.Join ("/", regexStringToStringArray (init));
                initDate = DateTime.ParseExact (initAfterRegex, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            } catch (System.Exception) {
                throw new InvalidOperationException ("Invalid Date.");
            }
            return initDate;
        }

        public static string[] regexStringToStringArray (string msg) {
            MatchCollection matchCol = Regex.Matches (msg, @"\d+");
            string[] strArray = new string[matchCol.Count];
            for (int i = 0; i < matchCol.Count; i++) {
                strArray[i] = matchCol[i].Groups[0].Value;
            }
            return strArray;
        }
    }

}
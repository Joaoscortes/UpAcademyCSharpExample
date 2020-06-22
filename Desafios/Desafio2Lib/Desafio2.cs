using System;
// Need for OrderBy || FirstOrDefault || Contains || Where || IsNullOrEmpty
using System.Linq;
// Need for Regex
using System.Text.RegularExpressions;

namespace Desafio2Lib {

	public class Desafio2 {
		public static string order (string init) {
			return resolution (init);
		}

		private static string resolution (string init) {
			/* 
			https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.orderby?view=netcore-3.1
			https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.regex?view=netcore-3.1
			*/
			return string.Join (" ",
				init.Split (' ')
				.Where (word => !string.IsNullOrEmpty (Regex.Match (word, @"\d").Value)).ToArray ()
				.OrderBy (word => Regex.Match (word, @"\d").Value));

			/* 
			https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.singleordefault?view=netcore-3.1
			*/
			// return string.Join (" ", init.Split ().OrderBy (word => word.SingleOrDefault (char.IsDigit)));

			// string[] words = init.Split (' ');
			// IOrderedEnumerable<string> orderedWords = words.OrderBy (word => word.ToList ().Find (digit => char.IsDigit (digit)));
			// return string.Join (" ", orderedWords);
		}

		private static string resolution1 (string init) {
			string[] words = init.Split (' ');
			string[] orderedWords = new string[10];

			// for (int indexWord = 0; indexWord < words.Length; indexWord++) {
			// 	string word = words[indexWord];

			// 	for (int indexChar = 0; indexChar < word.Length; indexChar++) {
			// 		Char currentChar = word[indexChar];

			// 		if (Char.IsDigit (currentChar)) {
			// 			int value = (int) Char.GetNumericValue (currentChar);
			// 			orderedWords[value] = word;
			// 		}
			// 	}
			// }
			foreach (string word in words) {

				foreach (Char currentChar in word) {

					if (Char.IsDigit (currentChar)) {
						int value = (int) Char.GetNumericValue (currentChar);
						orderedWords[value] = word;
					}
				}
			}
			orderedWords = orderedWords.Where (word => !string.IsNullOrEmpty (word)).ToArray ();
			return string.Join (" ", orderedWords);
		}

		private static string resolution2 (string init) {
			string result = "";
			string[] words = init.Split (' ');

			if (words.Length > 0) {
				for (int digit = 1; digit <= 9; digit++) {
					string first = words.FirstOrDefault (x => x.Contains (digit.ToString ())) + " ";

					if (first != " ") {
						Console.WriteLine (first);
						result += first;
					} else {
						Console.WriteLine ("Buuu");
					}
				}
			}

			return result.Trim ();
		}
	}
}
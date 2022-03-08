using System;

namespace TDETestTask10
{
	class Program
	{
		static int counter = 0;
		static void Main(string[] args)
		{
			string input = "aba";

			string str = Match_pair(input);
			Console.WriteLine(str);
			
		}

		public static string Match_pair(string input)
		{
			int i = 0;
			int j = input.Length;

			if (counter == 0 && input.Length > 4) // palindrome only makes sense when there's more than 2 characters
			{// plus its not wise to make this much computations if palindrome is short 
				string reversedInput = getReversedStr(input);

				if (input.Equals(reversedInput))
				{
					return "";
				}
			}

			if (input.Length > 0)
			{
				if (input[i] != input[input.Length - 1])
				{
					return new string(input[i] + "" + input[j - 1]);
				}
				else if (j == 1 || i == (j - 1)) 
				{ 
					return ""; 
				}

				i++;
				counter++;
				return Match_pair(input.Substring(i, j - 2)); 
			}

			counter = 0; // clear global variable
			return "";
		}

		private static string getReversedStr(string input)
		{
			char[] inputChar = input.ToCharArray();
			Array.Reverse(inputChar);
			return new string(inputChar);
		}

	}
}

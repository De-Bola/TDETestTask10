using System;

namespace TDETestTask10
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");

			string input = "hello";
			char[] inputChar = getReversedStr(input);

			string str = getMisMatch(inputChar);
			Console.WriteLine(str);
		}

		private static char[] getReversedStr(string input)
		{
			char[] inputChar = input.ToCharArray();
			Array.Reverse(inputChar);
			return inputChar;
		}

		public static string getMisMatch(char[] input)
		{
			int i = 0;

			return "{i}";
		}
	}
}

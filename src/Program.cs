using System;
using System.IO;
using System.Text.RegularExpressions;

namespace Samples.Tutorial.Recursive
{
	class Program
	{
		public static int Main(string[] args)
		{
			int num = 0;
			string snum;
			do
			{
				Console.Write("Enter a number [Max 13]: ");
				snum = Console.ReadLine();
			}
			while(!IsNumber(snum) || Int32.Parse(snum) > 14);
			num = Int32.Parse(snum);
			Console.WriteLine ("\n/*******OUTPUT**********/");
			Console.WriteLine ("El factorial de {0} es {1}",num,factorial(num));
			Console.WriteLine ("El número de fibonacci de {0} es {1}",num,fibonacci(num));
			return 0;
		}
		
		static bool IsNumber(string s)
		{
			string pattern = @"^\d+$";
			if(Regex.Match(s,pattern).Success)
				return true;
			return false;
		}
		
		static long factorial(int n)
		{
			if(n <= 1)
				return 1;
			else
				return n * factorial(n - 1);
		}
		
		static long fibonacci(int n)
		{
			if(n == 0 || n == 1)
				return n;
			else
				return fibonacci(n - 1) + fibonacci(n - 2);
		}
	}
}
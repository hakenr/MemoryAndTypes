using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackOverflow
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Press any key to crash... ;-)");
			Console.ReadKey();
			RecursiveLoop(0);
		}

		public static void RecursiveLoop(int hodnota)
		{
			Int64 a, b, c, d, e, f, g, h;
			string localString = "Pepa";

			RecursiveLoop((hodnota + 1) % 0xFFFF);
		}
	}
}

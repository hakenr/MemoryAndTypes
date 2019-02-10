using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haken.SlowStringChanges
{
	class Program
	{
		static void Main(string[] args)
		{
			const int length = 100000;
		
			string str;

			// klasické skládání stringů
			str = string.Empty;
			Stopwatch sw1 = new Stopwatch();
			sw1.Start();
			for (int i = 0; i < length; i++)
			{
				str = str + (char)(i % 26 + 65);
			}
			sw1.Stop();
			Console.WriteLine("string + string: {0:n0} ticks", sw1.ElapsedTicks);
			
			// StringBuilder
			str = string.Empty;
			var sw2 = new Stopwatch();
			sw2.Start();
			var sb = new StringBuilder();
			for (int i = 0; i < length; i++)
			{
				sb.Append((char)(i % 26 + 65));
			}
			str = sb.ToString();
			sw2.Stop();
			Console.WriteLine("StringBuilder: {0:n0} ticks", sw2.ElapsedTicks);

		}
	}
}

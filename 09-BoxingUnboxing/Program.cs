using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haken.BoxingUnboxing
{
	internal class Program
	{
		private static int counter = 0;
		private static void Main(string[] args)
		{
			/********************************************************************
			 * POZOR, nutno spustit opakovaně, aby se získal relevantní vzorek.
			 * ******************************************************************/
			var x = new MyStruct() { Value = 1 };

			// struct = předávání na stacku
			counter = 0;
			Stopwatch sw2 = new Stopwatch();
			sw2.Start();
			for (int i = 0; i < 10000000; i++)
			{
				IncrementValueStruct(x);
			}
			sw2.Stop();
			Console.WriteLine("MyStruct: {0:n0}", sw2.ElapsedTicks);

			// interface
			Stopwatch sw = new Stopwatch();
			sw.Start();
			for (int i = 0; i < 10000000; i++)
			{
				IncrementValueInterfaced(x);
			}
			sw.Stop();
			Console.WriteLine("ITypeWithValue: {0:n0}", sw.ElapsedTicks);

			// object
			counter = 0;
			Stopwatch sw1 = new Stopwatch();
			sw1.Start();
			for (int i = 0; i < 10000000; i++)
			{
				IncrementValueObject(x);
			}
			sw1.Stop();
			Console.WriteLine("object: {0:n0}", sw1.ElapsedTicks);

		}

		private static void IncrementValueInterfaced(ITypeWithValue parameter)
		{
			int value = parameter.Value;
			counter = counter + value;
		}

		private static void IncrementValueObject(object parameter)
		{
			int value = ((MyStruct)parameter).Value;
			counter = counter + value;
		}


		private static void IncrementValueStruct(MyStruct parameter)
		{
			int value = parameter.Value;
			counter = counter + value;
		}
	}

	public class MyClass : ITypeWithValue
	{
		public int Value { get; set; }
	}

	public struct MyStruct : ITypeWithValue
	{
		public int Value { get; set; }
	}

	interface ITypeWithValue
	{
		int Value { get; set; }
	}
}

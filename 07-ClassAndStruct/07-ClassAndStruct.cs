using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haken.ClassAndStruct
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			var x = new MyStruct() { Value = 10 };  // MyStruct?
			IncrementValue(x);
			Console.WriteLine(x.Value);
		}

		private static void IncrementValue(ITypeWithValue parameter)
		{
			parameter.Value++;
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

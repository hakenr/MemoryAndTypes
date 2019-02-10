using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haken.ByRefCallWithReferenceType
{
	class Program
	{
		static void Main(string[] args)
		{
			MyClass reference1 = new MyClass() { Data = 5 };
			MyClass reference2 = reference1;

			DoSomething(ref reference1);

			Console.WriteLine(reference1.Data);
			Console.WriteLine(reference2.Data);
			Console.WriteLine(reference1 == reference2);
			
			// viz analogie String (immutable)
		}

		private static void DoSomething(ref MyClass parameter)
		{
			int data = parameter.Data;
			data++;
			parameter = new MyClass() { Data = data };
		}
	}
	public class MyClass
	{
		public int Data { get; set; }
	}
}

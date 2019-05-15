using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haken.VirtualMembers
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			B b = new B();
			b.Foo();
			b.Bar();
			A a = b;
			a.Foo();
			a.Bar();
		}
		public class A
		{
			public void Foo()
			{
				Console.WriteLine("A.Foo");
			}
			public virtual void Bar()
			{
				Console.WriteLine("A.Bar");
			}
		}
		public class B : A
		{
			public void Foo()
			{
				Console.WriteLine("B.Foo");
			}
			public override void Bar()
			{
				Console.WriteLine("B.Bar");
			}
		}
	}
}
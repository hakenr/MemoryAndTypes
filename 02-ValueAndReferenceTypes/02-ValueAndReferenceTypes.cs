using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haken.ValueAndReferenceTypes
{
	class Program
	{
		static void Main(string[] args)
		{
			// 1
			int valueTypeVariable1 = 0xAAAA;
			// 2
			int valueTypeVariable2;
			// 3
			MyClass referenceTypeVariable1 = new MyClass();
			referenceTypeVariable1.ValueProperty = 1111;
			referenceTypeVariable1.ReferenceProperty = null;
			// 4
			MyClass referenceTypeVariable2;
			// 5
			string string1 = "Text";
			// 6
			string string2;
			// 7
			int[] arrayOfIntegers = new int[5];
			arrayOfIntegers[3] = 3;
			// 8
			int[] arrayOfIntegers2;
			// 9
			Coordinates coordinates1 = new Coordinates();
			coordinates1.X = 0xCC;
			coordinates1.Y = 0xDD;
			// 10
			Coordinates coordinates2;

			/****************************************************************************************************/
			Debugger.Break();
			/****************************************************************************************************/

			// přiřazení
			// 1, 2
			valueTypeVariable2 = valueTypeVariable1;
			valueTypeVariable1++;
			// 3, 4
			referenceTypeVariable2 = referenceTypeVariable1;
			referenceTypeVariable1.ReferenceProperty = referenceTypeVariable1;	// cyklická reference ;-)
			// 5, 6
			string2 = string1;
			// 7, 8
			arrayOfIntegers2 = arrayOfIntegers;
			arrayOfIntegers2[1] = 6;
			// 9, 10
			coordinates2 = coordinates1;
			coordinates2.X++;

			/****************************************************************************************************/
			Debugger.Break();
			/****************************************************************************************************/

			// 6
			string2 = "New Text";
			// 8
			Array.Resize(ref arrayOfIntegers2, 50);

			/****************************************************************************************************/
			Debugger.Break();
			/****************************************************************************************************/



			/*===================================================================================================*/
			// BONUS - String Interning
			/*===================================================================================================*/

			// 5, 6
			string1 = string1.ToLower();
			string2 = "text"; // String interning?
			// String.IsInterned(..)

			/****************************************************************************************************/
			Debugger.Break();
			/****************************************************************************************************/

			// 5, 6
			string1 = String.Intern(string1.ToLower());
			string2 = String.Intern("text");

			/****************************************************************************************************/
			Debugger.Break();
			/****************************************************************************************************/

		}
	}

	public class MyClass
	{
		public int ValueProperty { get; set; }

		public MyClass ReferenceProperty { get; set; }
	}

	public struct Coordinates
	{
		public Int16 X { get; set; }

		public Int16 Y { get; set; }
	}

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Haken.ArrayIsReferenceType
{
	class Program
	{
		static void Main(string[] args)
		{
			int[] arrayOfInts;							// proměnná je reference, instance ještě neexistuje	(v paměti je 0, tj. null)
			arrayOfInts = new int[50];					// vytvoření instance

			// špatně
			int[] arrayCopy = arrayOfInts;
			arrayCopy[5] = 5;
			Console.WriteLine(arrayOfInts[5]);			// mění se "obě" (jediné) pole

			// lépe
			arrayCopy = (int[])arrayOfInts.Clone();		// ICloneable
			arrayCopy[10] = 10;
			Console.WriteLine(arrayOfInts[10]);			// změnila se kopie pole


			// pozor též na Array.Resize() a více referencí na jedno pole
			int[] arrayReference2 = arrayOfInts;
			Array.Resize(ref arrayOfInts, 100);			// Resize vrátil referenci na novou větší instanci pole s kopií hodnot
			Console.WriteLine(arrayReference2.Length);	// ostatní reference na původní pole jsou však nedotčeny	
		}
	}
}

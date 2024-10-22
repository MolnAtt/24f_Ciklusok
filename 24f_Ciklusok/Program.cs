using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24f_Ciklusok
{
	internal class Program
	{
		static void Main(string[] args)
		{
            // BEOLVASÁS

			bool sikeres_e;
			int x;

			do
			{
				Console.WriteLine("Kérlek szépen téged, hogy adj meg nekem egy számot!");
				string input = Console.ReadLine();
				sikeres_e = int.TryParse(input, out x);
			} while (!sikeres_e); // hátultesztelős ciklus: 1-szer lefut a belseje, aztán ismétlődik addig, amíg muszáj.

			// Minden ilyen tesztelős ciklus után tudsz majd 1 dolgot biztosan:
			// Ebben a sorban, ahol most írok, a while-ben lévő állítás hamis kell legyen.


			// FELDOLGOZÁS: kiírjuk a négyzetét:

			int result = x * x;

			// KIÍRÁS:
			Console.WriteLine(result);


        }
	}
}

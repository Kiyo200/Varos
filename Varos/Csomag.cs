using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varos
{
	public class Csomag
	{
		public string Kuldo { get; }
		public string Cimzett { get; }
		public double Suly { get; }
		public double Ar { get; }
		public string Allapot { get; private set; }

		public Csomag(string kuldo, string cimzett, double suly, double ar)
		{
			Kuldo = kuldo;
			Cimzett = cimzett;
			Suly = suly;
			Ar = ar;
			Allapot = "Feldolgozás alatt";
		}

		public void Feladas() => Allapot = "Szállítás alatt";
		public void Szallitas() => Allapot = "Úton";
		public void Kiszallitas()
		{
			Allapot = "Kézbesítve";
			Console.WriteLine($"Csomag kézbesítve {Cimzett} részére.");
		}
	}
}

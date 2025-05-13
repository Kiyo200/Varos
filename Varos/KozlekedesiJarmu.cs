using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varos
{
	public class KozlekedesiJarmu
	{
		public string Nev { get; }
		public string Utvonal { get; }
		public int Ferohely { get; }
		public double Jegyar { get; }

		private List<Lakos> utasok = new List<Lakos>();

		public KozlekedesiJarmu(string nev, string utvonal, int ferohely, double jegyar)
		{
			Nev = nev;
			Utvonal = utvonal;
			Ferohely = ferohely;
			Jegyar = jegyar;
		}

		public void Felszallas(Lakos l)
		{
			if (utasok.Count < Ferohely && l.Fizet(Jegyar))
			{
				utasok.Add(l);
				Console.WriteLine($"{l.Nev} felszállt a(z) {Nev} járműre.");
			}
		}

		public void Lepes() => Console.WriteLine($"{Nev} halad az útvonalán: {Utvonal}");
	}

}

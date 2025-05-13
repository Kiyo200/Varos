using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varos
{
	public class Konyvtar
	{
		private List<Konyv> konyvek = new List<Konyv>();
		private int maxKapacitas;

		public Konyvtar(int kapacitas) => maxKapacitas = kapacitas;

		public void HozzaadKonyv(Konyv k) => konyvek.Add(k);

		public void Kolcsonoz(string cim)
		{
			var konyv = konyvek.FirstOrDefault(k => k.Cim == cim && k.Peldanyszam > 0);
			if (konyv != null)
			{
				konyv.Peldanyszam--;
				Console.WriteLine($"{cim} könyv kölcsönözve.");
			}
		}

		public void Belepes(Lakos l) => l.BelepSzolgaltatasba("Könyvtár");
	}

}
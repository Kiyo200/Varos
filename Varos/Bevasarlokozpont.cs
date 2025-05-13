using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varos
{
	public class Bevasarlokozpont
	{
		private List<string> boltok = new List<string>();
		private List<Lakos> latogatok = new List<Lakos>();

		public void UjBolt(string boltNev) => boltok.Add(boltNev);

		public void Belep(Lakos l) => latogatok.Add(l);

		public void Kolt(Lakos l, double osszeg)
		{
			if (l.Fizet(osszeg))
				Console.WriteLine($"{l.Nev} vásárolt a bevásárlóközpontban {osszeg} értékben.");
		}
	}

}

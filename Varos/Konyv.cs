using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varos
{
	public  class Konyv
	{
		public string Cim { get; }
		public string Szerzo { get; }
		public int Oldalszam { get; }
		public double Ertek { get; }
		public int Peldanyszam { get; set; }

		public Konyv(string cim, string szerzo, int oldalszam, double ertek, int peldanyszam)
		{
			Cim = cim;
			Szerzo = szerzo;
			Oldalszam = oldalszam;
			Ertek = ertek;
			Peldanyszam = peldanyszam;
		}
	}

}



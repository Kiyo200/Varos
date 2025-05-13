using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varos
{
	public class EtelItal
	{
		public string Nev { get; }
		public double Ar { get; }
		public string Tipus { get; } // "étel" vagy "ital"
		public double Koffein { get; }
		public int Kaloria { get; }

		public EtelItal(string nev, double ar, string tipus, double koffein, int kaloria)
		{
			Nev = nev;
			Ar = ar;
			Tipus = tipus;
			Koffein = koffein;
			Kaloria = kaloria;
		}
	}
}

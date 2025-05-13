using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varos
{
	public class Lakos
	{
		public string Nev { get; }
		public int Eletkor { get; }
		public string Lakcim { get; }
		private double penz;

		public Lakos(string nev, int eletkor, string lakcim, double penz)
		{
			Nev = nev;
			Eletkor = eletkor;
			Lakcim = lakcim;
			this.penz = penz;
		}

		public bool Fizet(double osszeg)
		{
			if (osszeg <= penz)
			{
				penz -= osszeg;
				return true;
			}
			return false;
		}

		public void BelepSzolgaltatasba(string szolgaltatasNev) =>
			Console.WriteLine($"{Nev} belépett a(z) {szolgaltatasNev} szolgáltatásba.");

		public void HasznalKozlekedest(KozlekedesiJarmu jarmu) => jarmu.Felszallas(this);
	}

}

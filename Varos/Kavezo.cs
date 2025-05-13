using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varos
{
	public class Kavezo
	{
		private List<EtelItal> menu = new List<EtelItal>();
		private List<Lakos> vendegek = new List<Lakos>();

		public void Rendel(Lakos l, EtelItal etel)
		{
			if (l.Fizet(etel.Ar))
			{
				vendegek.Add(l);
				Console.WriteLine($"{l.Nev} rendelt: {etel.Nev}");
				Fogyaszt(l, etel);
			}
		}

		private void Fogyaszt(Lakos l, EtelItal etel) =>
			Console.WriteLine($"{l.Nev} elfogyasztotta a(z) {etel.Nev} nevű {etel.Tipus}t.");
	}

	

}

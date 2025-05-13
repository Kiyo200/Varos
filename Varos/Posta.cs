using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Varos
{
	public class Posta
	{
		private List<Csomag> csomagok = new List<Csomag>();

		public void Kuldes(Csomag c)
		{
			csomagok.Add(c);
			c.Feladas();
		}

		public void Atvetel()
		{
			foreach (var c in csomagok) c.Kiszallitas();
		}

		public void SorbanAllas() => Console.WriteLine("Valaki sorban áll a postán.");
	}

	

}

namespace Varos
{
	public class Varos
	{
		private List<Lakos> lakosok = new List<Lakos>();
		private List<object> szolgaltatasok = new List<object>();

		public void HozzaadLakos(Lakos l) => lakosok.Add(l);
		public void SzolgaltatasInditasa(object sz) => szolgaltatasok.Add(sz);

		public void NapFutasa()
		{
			
		}

		public void VarosStatusza()
		{
			Console.WriteLine($"Lakosok száma: {lakosok.Count}, Szolgáltatások: {szolgaltatasok.Count}");
		}
	}

}


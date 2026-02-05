using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalisnyomozoo
{
	internal class EvidenceManager
	{

		private List<Evidence> lista;

		public EvidenceManager()
		{
			lista = new List<Evidence>();
		}


		public void BizonyitekHozzaadasa(int id)
		{

			Console.Write("Bizonyíték típusa: ");
			string tipus = Console.ReadLine();

			Console.Write("Bizonyíték leírása: ");
			string leiras = Console.ReadLine();

			int megbizhatosagiErtek = 0;
			bool mehet = false;

			do
			{
				Console.Write("Mehbízhatósági érték (0-10): ");
				if (int.TryParse(Console.ReadLine(), out megbizhatosagiErtek))
				{
					mehet = true;
				}
			} while (!mehet || megbizhatosagiErtek < 0 || megbizhatosagiErtek >= 11);
			
			

			Evidence bizonyitek = new Evidence(id, tipus, leiras, megbizhatosagiErtek);

			lista.Add(bizonyitek);
		}

		public void BizonyitekTorlese()
		{
			for (int i = 1; i <= lista.Count; i++) 
			{
				Console.WriteLine($"{i}: {lista[i-1]}");
			}
			Console.Write("Hanyadik elemet szeretné törölni: ");
			if (int.TryParse(Console.ReadLine(), out int hanyadik))
			{
				if(hanyadik <= lista.Count && hanyadik > 0)
				{
					Console.WriteLine($"{hanyadik}. elem törölve.");
					lista.RemoveAt(hanyadik-1);
				} else
				{
					Console.WriteLine("Nem létező adat");
				}

			} else
			{
				Console.WriteLine("Rossz adat megadva");
			}
			
		}




	}
}

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

			Console.Write("Mehbízhatósági érték: ");
			int megbizhatosagiErtek = Int32.Parse(Console.ReadLine());

			Evidence bizonyitek = new Evidence(id, tipus, leiras, megbizhatosagiErtek);

			lista.Add(bizonyitek);
		}
	}
}

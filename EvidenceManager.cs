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
		private int idSzamlalo = 0;

        internal List<Evidence> Lista { get => lista; set => lista = value; }

        public EvidenceManager()
		{
			Lista = new List<Evidence>();
		}

		
		public void BizonyitekHozzaadasa()
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
			
			

			Evidence bizonyitek = new Evidence(idSzamlalo, tipus, leiras, megbizhatosagiErtek);
			idSzamlalo++;
			Lista.Add(bizonyitek);
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
        }

        public void Listazas(List<Evidence> lista)
        {
            for (int i = 1; i <= lista.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"{i}: {lista[i - 1]}");
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
        }

        public void BizonyitekTorlese()
		{

			Listazas(Lista);
            Console.Write("Hanyadik elemet szeretné törölni: ");
			if (int.TryParse(Console.ReadLine(), out int hanyadik))
			{
				if(hanyadik <= Lista.Count && hanyadik > 0)
				{
					Console.WriteLine($"{hanyadik}. elem törölve.");
					Lista.RemoveAt(hanyadik-1);
				} else
				{
					Console.WriteLine("Nem létező adat");
				}

			} else
			{
				Console.WriteLine("Rossz adat megadva");
			}
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
        }



		public void Kivalaszto()
		{
            Console.WriteLine("Milyen műveletet szeretne végrehajtani?");
			string valasztas = "";
			do
			{
				Console.Write("Bizonyíték hozzáadása (H) | Bizonyíték törlése (T) | Bizonyítékok listázása (L) | Vissza (V) | ");
				valasztas = Console.ReadLine().ToUpper();
			} while (valasztas != "H" && valasztas != "T" && valasztas != "L" && valasztas != "V");

			switch (valasztas)
			{
				case "H": BizonyitekHozzaadasa();break;
                case "T": BizonyitekTorlese();break;
                case "L": Listazas(Lista);break;
				default: Console.WriteLine("----------------------------------------------------------------------------------------------------"); break;
            }


		}


	}
}

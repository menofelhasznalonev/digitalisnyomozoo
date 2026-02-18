using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalisnyomozoo
{
    internal class CaseManager
    {
        private List<Case> lista;
        private int idSzamlalo = 0;

        public CaseManager()
        {
            lista = new List<Case>();
        }



        
        public void UgyHozzaadasa(User felhasznalo, EvidenceManager em)
        {

            Console.Write("Ügy címe: ");
            string cim = Console.ReadLine();

            Console.Write("Ügy leírása: ");
            string leiras = Console.ReadLine();

            Console.Write("Ügy állapota: ");
            string allapot = Console.ReadLine();


            int hanyadik = 0;
            bool mehet = false;
            felhasznalo.EmberListazas();
            do
            {
                Console.Write("Hanyadik embert csatolja az ügyhöz: ");
                if (int.TryParse(Console.ReadLine(), out hanyadik))
                {
                    mehet = true;
                }
            } while (!mehet || hanyadik <= 0 || hanyadik > felhasznalo.emberekLista.Count);
            Person ember = felhasznalo.emberekLista[hanyadik-1];


            hanyadik = 0;
            mehet = false;
            em.Listazas();
            do
            {
                Console.Write("Hanyadik bizonyítékot csatolja az ügyhöz: ");
                if (int.TryParse(Console.ReadLine(), out hanyadik))
                {
                    mehet = true;
                }
            } while (!mehet || hanyadik <= 0 || hanyadik > em.Lista.Count);
            Evidence bizonyitek = em.Lista[hanyadik-1];




            Case ugy = new Case(idSzamlalo, cim, leiras, allapot, ember, bizonyitek);
            idSzamlalo++;
            lista.Add(ugy);
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
        }
    }
}

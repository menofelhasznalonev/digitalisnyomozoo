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


        EvidenceManager em = new EvidenceManager();
        public void UgyHozzaadasa()
        {

            Console.Write("Ügy címe: ");
            string cim = Console.ReadLine();

            Console.Write("Ügy leírása: ");
            string leiras = Console.ReadLine();

            Console.Write("Ügy állapota: ");
            string allapot = Console.ReadLine();



            

            int hanyadik = 0;
            bool mehet = false;
            em.Listazas();
            do
            {
                Console.Write("Hanyadik bizonyítékot csatolja az ügyhöz: ");
                if (int.TryParse(Console.ReadLine(), out hanyadik))
                {
                    mehet = true;
                }
            } while (!mehet || hanyadik <= 0 || hanyadik >= em.Lista.Count-1);
            Evidence bizonyitek = em.Lista[hanyadik];




            Case ugy = new Case(cim, leiras, allapot, bizonyitek, );
            idSzamlalo++;
            lista.Add(ugy);
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
        }
    }
}

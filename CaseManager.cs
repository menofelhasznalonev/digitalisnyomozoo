using System;
using System.Collections;
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


            string valasztas = "";
            List<Person> ember = [];
            do
            {
                int hanyadik = 0;
                bool mehet = false;
                valasztas = "N";
                List<Person> emberValasztas = felhasznalo.emberekLista;
                felhasznalo.EmberListazas(emberValasztas);
                do
                {
                    Console.Write("Hanyadik embert csatolja az ügyhöz: ");
                    if (int.TryParse(Console.ReadLine(), out hanyadik))
                    {
                        mehet = true;
                    }
                } while (!mehet || hanyadik <= 0 || hanyadik > felhasznalo.emberekLista.Count);
                ember.Add(emberValasztas[hanyadik - 1]);
                emberValasztas.RemoveAt(hanyadik - 1);

                if (emberValasztas.Count > 0)
                {
                    Console.Write("Szeretne még hozzáadni embert? (I/N): ");
                    do
                    {
                        valasztas = Console.ReadLine().ToUpper();
                    } while (valasztas != "I" && valasztas != "N");
                }

            } while (valasztas == "I");




            List<Evidence> bizonyitek = [];
            do
            {
                int hanyadik = 0;
                bool mehet = false;
                valasztas = "N";
                List<Evidence> bizonyitekValasztas = em.Lista;
                em.Listazas(bizonyitekValasztas);
                do
                {
                    Console.Write("Hanyadik embert csatolja az ügyhöz: ");
                    if (int.TryParse(Console.ReadLine(), out hanyadik))
                    {
                        mehet = true;
                    }
                } while (!mehet || hanyadik <= 0 || hanyadik > felhasznalo.emberekLista.Count);
                bizonyitek.Add(bizonyitekValasztas[hanyadik - 1]);
                bizonyitekValasztas.RemoveAt(hanyadik - 1);

                if (bizonyitekValasztas.Count > 0)
                {
                    Console.Write("Szeretne még hozzáadni embert? (I/N): ");
                    do
                    {
                        valasztas = Console.ReadLine().ToUpper();
                    } while (valasztas != "I" && valasztas != "N");
                }

            } while (valasztas == "I");




            Case ugy = new Case(idSzamlalo, cim, leiras, allapot, ember, bizonyitek);
            idSzamlalo++;
            lista.Add(ugy);
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
        }

        public void UgyListazasa()
        {
            for (int i = 1; i <= lista.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"{i}: {lista[i - 1]}");
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
        }

        public void UgyTorlese()
        {

            UgyListazasa();
            Console.Write("Hanyadik elemet szeretné törölni: ");
            if (int.TryParse(Console.ReadLine(), out int hanyadik))
            {
                if (hanyadik <= lista.Count && hanyadik > 0)
                {
                    Console.WriteLine($"{hanyadik}. elem törölve.");
                    lista.RemoveAt(hanyadik - 1);
                }
                else
                {
                    Console.WriteLine("Nem létező adat");
                }

            }
            else
            {
                Console.WriteLine("Rossz adat megadva");
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
        }

        public void Kivalaszto(User felhasznalo, EvidenceManager em)
        {
            Console.WriteLine("Milyen műveletet szeretne végrehajtani?");
            string valasztas = "";
            do
            {
                Console.Write("Ügy hozzáadása (H) | Ügy törlése (T) | Ügyek listázása (L) | Vissza (V) | ");
                valasztas = Console.ReadLine().ToUpper();
            } while (valasztas != "H" && valasztas != "T" && valasztas != "L" && valasztas != "V");

            switch (valasztas)
            {
                case "H": UgyHozzaadasa(felhasznalo, em); break;
                case "T": UgyTorlese(); break;
                case "L": UgyListazasa(); break;
                default: Console.WriteLine("----------------------------------------------------------------------------------------------------"); break;
            }


        }
    }
}

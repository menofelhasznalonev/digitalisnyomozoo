using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalisnyomozoo
{
    internal class DecisionEngine
    {

        Random r = new Random();
        List<Suspect> gyanusitottLista = new List<Suspect>();

        public void GyanusitottsagModositas()
        {

            GyanusitottListazas(gyanusitottLista);
            int hanyadik = 0;
            bool mehet = false;
            do
            {
                Console.Write("Melyik gyanusított gyanúszintjét akarja változtatni: ");
                if (int.TryParse(Console.ReadLine(), out hanyadik))
                {
                    mehet = true;
                }
            } while (!mehet || hanyadik <= 0 || hanyadik > gyanusitottLista.Count);

            int mennyi = 0;
            mehet = false;
            do
            {
                Console.Write("Mekkora legyen a gyanusítottsági szint: ");
                if (int.TryParse(Console.ReadLine(), out mennyi))
                {
                    mehet = true;
                }
            } while (!mehet || mennyi <= 0 || mennyi > 100);

            gyanusitottLista[hanyadik-1].GyanusitottsagiSzint = mennyi;

        }

        public void GyanusitottListazas(List<Suspect> lista)
        {
            for (int i = 1; i <= lista.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"{i}: {lista[i - 1]}");
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
        }

        public void KezdoGyanusitas(Evidence bizonyitek, List<Person> emberekLista)
        {
            List<Evidence> bizLista = [bizonyitek];
            Suspect gyanusitott = new Suspect(emberekLista[r.Next(0, emberekLista.Count())], r.Next(0, 101), "Elbírálásra vár", bizLista);

            gyanusitottLista.Add(gyanusitott);
        }
    }
}

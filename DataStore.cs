using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalisnyomozoo
{
    internal class DataStore
    {
        Random r = new Random();
        public List<Person> emberekLista = [];
        public List<Suspect> gyanusitottakLista = [];
        private List<string> vNev = ["Nagy", "Kovács", "Tóth", "Szabó", "Horváth", "Varga", "Kiss", "Molnár", "Németh", "Balogh"];
        private List<string> kNev = ["Viktória", "Vivien", "Anna", "Alexandra", "Fanni", "Dániel", "Dávid", "Bence", "Máté", "Tamás"];



        public void EmberGeneralas()
        {


            for (int i = 0; i < 10; i++)
            {
                Person ember = new Person($"{vNev[r.Next(0, 10)]} {kNev[r.Next(0, 10)]}", r.Next(18, 81), "Még nincs megjegyzés");
                emberekLista.Add(ember);
            }
        }

        public void EmberListazas(List<Person> emberekLista)
        {
            for (int i = 1; i <= emberekLista.Count; i++)
            {
                Console.WriteLine();
                Console.WriteLine($"{i}: {emberekLista[i - 1]}");
            }
            Console.WriteLine("----------------------------------------------------------------------------------------------------");
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalisnyomozoo
{
	internal class User
	{
		private string nev;
		private int id;
		private string szerepkor;

		public List<Person> emberekLista = [];
        private List<string> vNev = ["Nagy", "Kovács", "Tóth", "Szabó", "Horváth", "Varga", "Kiss", "Molnár", "Németh", "Balogh"];
        private List<string> kNev = ["Viktória", "Vivien", "Anna", "Alexandra", "Fanni", "Dániel", "Dávid", "Bence", "Máté", "Tamás"];

        public User(string nev, int id, string szerepkor)
		{
			this.nev = nev;
			this.id = id;
			this.szerepkor = szerepkor;
		}

		public string Nev { get => nev; set => nev = value; }
		public int Id 
		{
			get
			{
				return id;
			}
		}
		public string Szerepkor { get => szerepkor; set => szerepkor = value; }

        public void EmberGeneralas()
        {
            Random r = new Random();

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

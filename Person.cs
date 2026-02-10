using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalisnyomozoo
{
	internal class Person
	{
		private string nev;
		private int eletkor;
		private string megjegyzes;
        private List<Evidence> lista;

        public Person(string nev, int eletkor, string megjegyzes, List<Evidence> lista)
        {
            this.nev = nev;
            this.eletkor = eletkor;
            this.megjegyzes = megjegyzes;
            this.Lista = lista;
        }

        public string Nev { get => nev; set => nev = value; }
		public int Eletkor { get => eletkor; set => eletkor = value; }
		public string Megjegyzes { get => megjegyzes; set => megjegyzes = value; }
        internal List<Evidence> Lista { get => lista; set => lista = value; }

        private void Feltoltes()
        {


        }
    }
}

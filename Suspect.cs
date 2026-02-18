using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalisnyomozoo
{
	internal class Suspect
	{
		private Person szemely;
		private int gyanusitottsagiSzint;
		private string statusz;
        private List<Evidence> lista;



        public Suspect(Person szemely, int gyanusitottsagiSzint, string statusz, List<Evidence> lista)
		{
			this.szemely = szemely;
			this.gyanusitottsagiSzint = gyanusitottsagiSzint;
			this.statusz = statusz;
            this.Lista = lista;
        }

		public int GyanusitottsagiSzint { get => gyanusitottsagiSzint; set => gyanusitottsagiSzint = value; }
		public string Statusz { get => statusz; set => statusz = value; }
		internal Person Szemely { get => szemely; set => szemely = value; }
        internal List<Evidence> Lista { get => lista; set => lista = value; }



        public override string ToString()
        {
            string formazott = $"Név: {this.szemely.Nev} | Gyanusítottsági szint: {this.gyanusitottsagiSzint} | Státusz: {this.statusz} | Bizonyítéktípus(ok): ";
			foreach (Evidence item in lista)
			{
				formazott += item.Tipus;
			}
			return formazott;
        }

    }


}

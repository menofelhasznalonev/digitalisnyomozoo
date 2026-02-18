using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Dataflow;

namespace digitalisnyomozoo
{
	internal class Case
	{
		private int id;
		private string cim;
		private string leiras;
		private string allapot;
		private List<Person> szemely;
		private List<Evidence> bizonyitek;


        public Case(int id, string cim, string leiras, string allapot, List<Person> szemely, List<Evidence> bizonyitek)
        {
            this.Id = id;
            this.Cim = cim;
            this.Leiras = leiras;
            this.Allapot = allapot;
            this.Szemely = szemely;
            this.Bizonyitek = bizonyitek;
        }

        public int Id { get => id; set => id = value; }
        public string Cim { get => cim; set => cim = value; }
        public string Leiras { get => leiras; set => leiras = value; }
        public string Allapot { get => allapot; set => allapot = value; }
        internal List<Person> Szemely { get => szemely; set => szemely = value; }
        internal List<Evidence> Bizonyitek { get => bizonyitek; set => bizonyitek = value; }

        public override string ToString()
        {
            string formazott = $"Ügy címe: {this.Cim} | Leírása: {this.Leiras} | Állapota: {this.Allapot} | Hozzácsatolt ember(ek): ";
            foreach (Person item in Szemely) 
            { 
                formazott += (item.Nev + ", ");
            }
            formazott += ("| Hozzácsatolt bizonyíték(ok): ");
            foreach (Evidence item in Bizonyitek)
            {
                formazott += ($"{item.Tipus}({item.MegbizhatosagiErtek}/5) ");
            }
            return formazott;
        }
    }
}

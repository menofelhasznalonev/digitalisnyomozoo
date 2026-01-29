using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalisnyomozoo
{
	internal class Case
	{
		private int id;
		private string cim;
		private string leiras;
		private string allapot;
		private Person szemely;
		private Evidence bizonyitek;


		public Case(int id, string cim, string leiras, string allapot, Person szemely, Evidence bizonyitek)
		{
			this.id = id;
			this.cim = cim;
			this.leiras = leiras;
			this.allapot = allapot;
			this.szemely = szemely;
			this.bizonyitek = bizonyitek;
		}

		public int Id {
			get 
			{ 
				return id;
			}

			set
			{
				this.id = value;
			}
		}
		public string Cim { get => cim; set => cim = value; }
		public string Leiras { get => leiras; set => leiras = value; }
		public string Allapot { get => allapot; set => allapot = value; }
		internal Person Szemely { get => szemely; set => szemely = value; }
		internal Evidence Bizonyitek { get => bizonyitek; set => bizonyitek = value; }
	}
}

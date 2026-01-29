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
		//private Evidence bizonyitek;

		public Case(int id, string cim, string leiras, string allapot, Person szemely)
		{
			this.id = id;
			this.cim = cim;
			this.leiras = leiras;
			this.allapot = allapot;
			this.szemely = szemely;
		}
		






	}
}

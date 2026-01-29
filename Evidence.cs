using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalisnyomozoo
{
	internal class Evidence
	{
		private int id;
		private string tipus;
		private string leiras;
		private int megbizhatosagiErtek;

		public Evidence(int id, string tipus, string leiras, int megbizhatosagiErtek)
		{
			this.id = id;
			this.tipus = tipus;
			this.leiras = leiras;
			this.megbizhatosagiErtek = megbizhatosagiErtek;
		}
	}
}

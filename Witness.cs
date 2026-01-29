using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalisnyomozoo
{
	internal class Witness
	{
		private Person szemely;
		private string vallomas;
		private DateTime vallomasDatuma;

		public Witness(Person szemely, string vallomas, DateTime vallomasDatuma)
		{
			this.szemely = szemely;
			this.vallomas = vallomas;
			this.vallomasDatuma = vallomasDatuma;
		}

		public string Vallomas { get => vallomas; set => vallomas = value; }
		public DateTime VallomasDatuma { get => vallomasDatuma; set => vallomasDatuma = value; }
		internal Person Szemely { get => szemely; set => szemely = value; }
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalisnyomozoo
{
	internal class CaseStatus
	{
		private string aktualisStatus;
		private string feladata;
		private string allapotvaltozasokKezelese;

		public CaseStatus(string aktualisStatus, string feladata, string allapotvaltozasokKezelese)
		{
			this.aktualisStatus = aktualisStatus;
			this.feladata = feladata;
			this.allapotvaltozasokKezelese = allapotvaltozasokKezelese;
		}

		public string AktualisStatus { get => aktualisStatus; set => aktualisStatus = value; }
		public string Feladata { get => feladata; set => feladata = value; }
		public string AllapotvaltozasokKezelese { get => allapotvaltozasokKezelese; set => allapotvaltozasokKezelese = value; }
	}
}

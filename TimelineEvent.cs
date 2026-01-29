using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace digitalisnyomozoo
{
	internal class TimelineEvent
	{
		private DateTime datum;
		private string esemenyLeirasa;

		public TimelineEvent(DateTime datum, string esemenyLeirasa)
		{
			this.datum = datum;
			this.esemenyLeirasa = esemenyLeirasa;
		}

		public DateTime Datum { get => datum; set => datum = value; }
		public string EsemenyLeirasa { get => esemenyLeirasa; set => esemenyLeirasa = value; }
	}
}

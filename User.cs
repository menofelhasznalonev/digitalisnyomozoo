using System;
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

		public User(string nev, int id, string szerepkor)
		{
			this.nev = nev;
			this.id = id;
			this.szerepkor = szerepkor;
		}
	}
}

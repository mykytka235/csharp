using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
	public class Administrator
	{
		string username;
		string password;

		public Administrator()
		{
			username = "admin";
			password = "admin";
		}
		public Administrator(string username, string password)
		{
			this.username = username;
			this.password = password;

		}
	}
}

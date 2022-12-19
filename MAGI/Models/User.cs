using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGI.Models
{
	public class User:EntityModel
	{
		public string FirstName { get; set; }
		public string Patronymic { get; set; }
		public string LastName { get; set; }
		Roles roles { get; set; }
	}
}

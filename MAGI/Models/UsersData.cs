using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGI.Models
{
	public class UsersData:EntityModel
	{
		public string AuthenticationData { get; set; }
		public User UserID { get; set; }
	}
}

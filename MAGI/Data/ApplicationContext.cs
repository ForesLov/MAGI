using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAGI.Models;
using Microsoft.EntityFrameworkCore;
namespace MAGI.Data
{
	public class ApplicationContext:DbContext
	{
		public ApplicationContext() => Database.EnsureCreated();
		public DbSet<User> users => Set<User>();
		public DbSet<UsersData> usersData=> Set<UsersData>();
		public DbSet <Roles> roles => Set<Roles>();
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Data Source=Magi.db");
		}
	}
}

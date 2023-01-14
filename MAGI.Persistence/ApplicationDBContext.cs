using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MAGI.Models;

namespace MAGI.Persistece;

public class ApplicationDBContext : DbContext
{
    public ApplicationDBContext(DbContextOptions options) : base(options) { Database.EnsureCreated(); }
    public DbSet<Database> ObservedDatabases { get; set; }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGI.Models
{
    public class ObservedInfo : EntityBase
    {
        public List<DbTable> ObservedTables { get; set; } = new ();
    }
}

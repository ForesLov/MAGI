using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGI.Models
{
    public class DbTable:EntityBase
    {
        public string Name { get; set; }
        List<DbTableColumn> DbTableColumns { get; set; }
    }
}

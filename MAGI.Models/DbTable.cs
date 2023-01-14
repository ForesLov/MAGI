using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGI.Models
{
    public class DbTable
    {
        public string Name { get; set; }
        List<DbTableColumn> DbTableColumns { get; set; }
    }
}

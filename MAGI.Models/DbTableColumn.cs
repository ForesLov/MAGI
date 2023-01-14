using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGI.Models
{
    public class DbTableColumn : EntityBase
    {
        public string Name { get; set; }
        public string Type { get; set; }

    }
}

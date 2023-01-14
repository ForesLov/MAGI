using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAGI.Models
{
    /// <summary>
    /// База для создания создания объектов, которые хранятся в БД.
    /// </summary>
    public abstract class EntityBase
    {
        /// <summary>
        /// Уникальный идентификатор.
        /// </summary>
        public Guid ID { get; set; }
    }
}

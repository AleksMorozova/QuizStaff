using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DomainModel
{
    public class Entity
    {
        [Key]
        public virtual Guid ID { get; set; }
    }
}

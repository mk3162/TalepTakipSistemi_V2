using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Entities
{
    public class BaseTedarikci
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TedarikciId { get; set; }
    }
}

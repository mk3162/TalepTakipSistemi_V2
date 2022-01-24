using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Entities
{
    public class Tip
    {
        [Key]
        public int SiraNo { get; set; }
        [StringLength(32)]
        public string Tanimi { get; set; }
    }
}

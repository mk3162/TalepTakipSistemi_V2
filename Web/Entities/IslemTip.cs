using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Entities
{
    public class IslemTip
    {
        [Key]
        public int SiraNo { get; set; }
        public string Tanimi { get; set; }
    }
}

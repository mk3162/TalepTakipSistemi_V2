using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Web.Service.Interface;

namespace Web.Entities
{
    public class Urun :  IEntity
    {
        [StringLength(25),Key]
        public string UrunKodu { get; set; }
        [StringLength(127),Required]
        public string UrunTanimi { get; set; }
    }
}

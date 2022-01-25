using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Web.Service.Interface;

namespace Web.Entities
{
    public class Urun : BaseUrun , IEntity
    {
        [StringLength(25),Key]
        public string UrunKodu { get; set; }
        [StringLength(127)]
        public string UrunTanimi { get; set; }
    }
}

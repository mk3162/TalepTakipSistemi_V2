using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Web.Service.Interface;

namespace Web.Entities
{
    public class Tedarikci :  IEntity
    {
        [StringLength(25),Key]
        public string TedarikciKodu { get; set; }
        [StringLength(127),Required]
        public string TedarikciUnvani { get; set; }
    }
}

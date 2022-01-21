using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Web.Service.Interface;

namespace Web.Entities
{
    public class Tedarikci : BaseTedarikci, IEntity
    {
        [StringLength(25)]
        public string TedarikciKodu { get; set; }
        [StringLength(127)]
        public string TedarikciUnvani { get; set; }
    }
}

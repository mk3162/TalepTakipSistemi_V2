using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Service.Interface;

namespace Web.Entities
{
    public class Urun : BaseUrun , IEntity
    {
        public string UrunKodu { get; set; }
        public string UrunTanimi { get; set; }
    }
}

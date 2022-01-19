using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Web.Service.Interface;

namespace Web.Entities
{
    public class Kullanici: BaseEntity, IEntity 
    {
        public string Kodu { get; set; }
        public string Sifre { get; set; }
        public string AdiSoyadi { get; set; }
        public int Yetki { get; set; }
    }
}

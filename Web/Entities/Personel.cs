using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Web.Service.Interface;

namespace Web.Entities
{
    public class Personel : IEntity
    {
        [Required,StringLength(12),Key]
        public string Kodu { get; set; }
        [Required,StringLength(48)]
        public string AdiSoyadi { get; set; }
        [Required,StringLength(48)  ]
        public string Unvani { get; set; }
        [Required]
        public int ServisSiraNo { get; set; }
        public virtual Servis Servis { get; set; }

        [Required]
        public int Oncelik { get; set; }
        [Required]
        public int Pasif { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Web.Service.Interface;

namespace Web.Entities
{
    public class Sirket : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SiraNo { get; set; }
        [StringLength(48),Required]
        public string Tanimi { get; set; }
        public List<Departman> Departmanlar { get; set; }
        public List<Lokasyon> Lokasyonlar { get; set; }
        public List<Proje> Projeler { get; set; }
        public List<MasrafMerkez> MasrafMerkezler { get; set; }
    }
}

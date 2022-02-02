using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Web.Service.Interface;

namespace Web.Entities
{
    public class Proje : IEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SiraNo { get; set; }
        [Required, StringLength(5)]
        public string Kodu { get; set; }
        [Required, StringLength(48)]
        public string Tanimi { get; set; }
        [Required]
        public int SirketSiraNo { get; set; }
        public Sirket Sirket { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Entities
{
    public class Proje
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SiraNo { get; set; }
        [Required]
        public string Kodu { get; set; }
        [Required]
        public string Tanimi { get; set; }
        [Required]
        public int SirketSiraNo { get; set; }
        public Sirket Sirket { get; set; }
    }
}

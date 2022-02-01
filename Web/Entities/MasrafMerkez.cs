using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Entities
{
    public class MasrafMerkez
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SiraNo { get; set; }
        [Required,StringLength(48)]
        public string Tanimi { get; set; }
        [Required, StringLength(16)]
        public string MuhasebeKodu1 { get; set; }
        [Required, StringLength(16)]
        public string MuhasebeKodu2 { get; set; }
        [Required, StringLength(16)]
        public string MuhasebeKodu3 { get; set; }

        [Required]
        public int SirketSiraNo { get; set; }
        public Sirket Sirket { get; set; }
    }
}

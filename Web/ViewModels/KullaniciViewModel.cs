using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewModels
{
    public class KullaniciViewModel
    {
        [Key,StringLength(12)]
        public string Kodu { get; set; }
        [Required]
        public string Sifre { get; set; }
    }
}

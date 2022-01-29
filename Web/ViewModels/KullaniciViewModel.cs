using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewModels
{
    public class KullaniciViewModel
    {
        [Key, Required]
        public string Kodu { get; set; }
        [StringLength(12), Required]
        public string Sifre { get; set; }
    }
}

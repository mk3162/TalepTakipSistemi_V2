using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.ViewModels
{
    public class UserViewModel
    {
        [Key, Required]
        public string Kodu { get; set; }

        [StringLength(12), Required]
        [DataType(DataType.Password)]
        public string Sifre { get; set; }
        public string ReturnUrl { get; set; }
        public string AdiSoyadi { get; set; }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Web.Service.Interface;

namespace Web.Entities
{
    public class Kullanici : BaseKullanici, IEntity
    {
        [StringLength(12),Key]
        public string Kodu { get; set; }
        [StringLength(12), Required]
        public string Sifre { get; set; }
        [StringLength(48), Required]
        public string AdiSoyadi { get; set; }
        [Required]
        public int Yetki { get; set; }

        public enum Aut 
        { 
            Kullanıcı,
            Admin
        }
    }
}

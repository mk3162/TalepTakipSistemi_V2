using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Web.Service.Interface;

namespace Web.Entities
{
    public class Departman: IEntity
    {
        [Key,DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SiraNo { get; set; }
        [StringLength(48),Required]
        public string Tanimi { get; set; }
        [Required]
        public int SirketSiraNo { get; set; }
        public Sirket Sirket { get; set; }

    }
}

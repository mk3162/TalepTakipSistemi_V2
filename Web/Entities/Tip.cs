using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Web.Service.Interface;

namespace Web.Entities
{
    public class Tip : IEntity
    {
        [Key]
        public int SiraNo { get; set; }
        [StringLength(32)]
        public string Tanimi { get; set; }
    }
}

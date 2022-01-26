using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Web.Service.Interface;

namespace Web.Entities
{
    public class Servis : IEntity
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SiraNo { get; set; }
        [Required,StringLength(48)]
        public string Tanimi { get; set; }
        [Required]
        public int DepartmanSiraNo { get; set; }
        public Departman Departman { get; set; }

        public List<Personel> Personeller { get; set; }
    }
}

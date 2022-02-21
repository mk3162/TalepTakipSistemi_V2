using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Models.Response
{
    public class ResponseKullanicilarListesiDto
    {
        public string Kodu { get; set; }
        public string Sifre { get; set; }
        public string AdiSoyadi { get; set; }
        public int Yetki { get; set; }
        public string Rol { get; set; }
        public enum Roles
        {
            AD, YU, AŞY, YM, PM, ÜKM, AM, GM, SM, GMA, SU
        }
    }
}

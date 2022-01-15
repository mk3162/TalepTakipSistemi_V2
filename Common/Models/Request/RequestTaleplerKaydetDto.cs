using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Models.Request
{
    public class RequestTaleplerKaydetDto
    {
		public int SiraNo { get; set; }
		public int GrupSiraNo { get; set; }
		public string SahibiKodu { get; set; }
		public string UrunKodu { get; set; }
		public int TipSiraNo { get; set; }
		public int ProjeSiraNo { get; set; }
		public int MasrafMerkeziSiraNo { get; set; }
	    public int LokasyonSiraNo { get; set; }
		public decimal Miktar { get; set; }
		public string MiktarBirim { get; set; }
		public string Aciklama { get; set; }
		public string TeslimYeri { get; set; }
		public string KaydiYapan { get; set; }
		public int Sonuc { get; set; }
	}
}

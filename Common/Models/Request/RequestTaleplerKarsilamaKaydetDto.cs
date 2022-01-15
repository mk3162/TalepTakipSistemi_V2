using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Models.Request
{
    public class RequestTaleplerKarsilamaKaydetDto
    {
		public int SiraNo { get; set; }
		public int TalepSiraNo { get; set; }
		public DateTime FiiliGelisTarihi { get; set; }
		public string IrsaliyeNo { get; set; }
		public DateTime IrsaliyeTarihi { get; set; }
		public decimal Miktar { get; set; }
		public decimal BirimFiyat { get; set; }
		public string ParaBirimi { get; set; }
		public decimal ToplamFiyat { get; set; }
		public string KaydiYapan { get; set; }
        public DateTime KayitZamani { get; set; }
    }
}

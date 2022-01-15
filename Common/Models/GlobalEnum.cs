using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Common.Models
{
    public class GlobalEnum
    {
        public enum StoredProcedure
        {
            #region  
            [Display(Name = "dbo")]
            SirketlerListesi,
            [Display(Name = "dbo")]
            DepartmanlarListesi,
            [Display(Name = "dbo")]
            ServislerListesi,
            [Display(Name = "dbo")]
            LokasyonlarListesi,
            [Display(Name = "dbo")]
            MasrafMerkezleriListesi,
            [Display(Name = "dbo")]
            ProjelerListesi,
            [Display(Name = "dbo")]
            TedarikcilerListesi,
            [Display(Name = "dbo")]
            TiplerListesi,
            [Display(Name = "dbo")]
            UrunlerListesi,
            #endregion

        }

        public enum DbModelType
        {
            PostreSQL,
            Oracle,
            MSSql
        }

    }
}

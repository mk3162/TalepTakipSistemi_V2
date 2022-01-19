using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Session
{
    public class SessionUserModel
    {
        public string Kodu { get; set; }
        public string Sifre { get; set; }
        public string AdiSoyadi { get; set; }
        public int Yetki { get; set; }

        public SessionUserModel()
        {

        }

        public static SessionUserModel CurrentUser
        {
            get
            {
                return null;
                //if (HttpContext.Current.Session[_cookieUserKey] == null)
                //{
                //    return null;
                //}
                //else
                //{
                //    return HttpContext.Current.Session[_cookieUserKey] as SessionUserModel;
                //}
            }
            set
            {
                //if (value is SessionUserModel)
                //{
                //    SessionUserModel m = value as SessionUserModel;
                //    HttpContext.Current.Session[_cookieUserKey] = m;
                //}
            }
        }
        private static string _cookieUserKey = "Sample_User";
    }
}

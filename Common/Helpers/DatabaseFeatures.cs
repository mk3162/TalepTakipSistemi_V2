using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Common.Helpers
{
    public class DatabaseFeatures
    {
        public static string GetConn()
        {
            return new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("DataBase")["Conn"].ToString();
        }
        public static string GetSchemas()
        {
            return new ConfigurationBuilder().AddJsonFile("appsettings.json").Build().GetSection("DataBase")["Schemas"].ToString();
        }
    }
}

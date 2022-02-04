using Common.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Service.Interface
{
   public interface IServiceManager
    {
        RequestResponse<T> Get<T>(string url);
 
        RequestResponse<T> Delete<T, Y>(string url, Y model);
        RequestResponse<T> Post<T, Y>(string url, Y model);
    }
}

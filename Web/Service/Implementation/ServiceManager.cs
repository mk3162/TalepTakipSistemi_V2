using Common.Models.Request;
using Common.Models.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.Helper;
using Web.Service.Interface;

namespace Web.Service.Implementation
{
    public class ServiceManager : IServiceManager
    {
        private readonly RequestParameter _req;
        public ServiceManager(RequestParameter req)
        {
            _req = req;
        }

        public RequestResponse<T> Get<T>(string url)
        {
            try
            {
                _req.Url = url;

                var jsonResult = JsonConvert.DeserializeObject<RequestResponse<T>>(RequestManager.GetMethod(_req).ToString());

                return jsonResult == null ? new RequestResponse<T>() : jsonResult;
            }
            catch (Exception)
            {
 
                return new RequestResponse<T>();
            }
        }

        public RequestResponse<T> Post<T, Y>(string url, Y model)
        {

            try
            {
                _req.Url = url;


                _req.Data = JsonConvert.SerializeObject(model);

                var jsonResult = JsonConvert.DeserializeObject<RequestResponse<T>>(RequestManager.PostMethod(_req).ToString());

                return jsonResult == null ? new RequestResponse<T>() : jsonResult;
            }
            catch (Exception)
            {

                return new RequestResponse<T>();

            }
        }

        public RequestResponse<T> Put<T, Y>(string url, Y model)
        {
            // Delete metodunda PUT ??
            try
            {
                _req.Url = url;


                _req.Data = JsonConvert.SerializeObject(model);

                //var response = RequestManager.PutMethod(_req).ToString();
                var jsonResult = JsonConvert.DeserializeObject<RequestResponse<T>>(RequestManager.PutMethod(_req).ToString());
                return jsonResult == null ? new RequestResponse<T>() : jsonResult;
            }
            catch (Exception)
            {

                return new RequestResponse<T>();

            }
        }

        public RequestResponse<T> Delete<T, Y>(string url, Y model)
        {

            try
            {
                _req.Url = url;


                _req.Data = JsonConvert.SerializeObject(model);

                var jsonResult = JsonConvert.DeserializeObject<RequestResponse<T>>(RequestManager.DeleteMethod(_req).ToString());

                return jsonResult == null ? new RequestResponse<T>() : jsonResult;
            }
            catch (Exception)
            {

                return new RequestResponse<T>();

            }
        }
    }
}

using Common.Models.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Web.Helper
{
    public class RequestManager
    {
        public static string GetMethod(RequestParameter model)
        {
            using (var httpClient = new HttpClient())
            {

                HttpResponseMessage response = httpClient.GetAsync(model.Url).Result;

                //Log Eklenmek isteniyorsa buraya eklenmesi gerekiyor
                //if(Convert.ToInt32(response.StatusCode) != 200)

                string result = response.Content.ReadAsStringAsync().Result;
                return result;
            }

        }

        public static string PostMethod(RequestParameter model)
        {
            using (var httpClient = new HttpClient())
            {
                var data = new System.Net.Http.StringContent(model.Data, Encoding.UTF8, "application/json");
                HttpResponseMessage response = httpClient.PostAsync(model.Url, data).Result;

                //Log Eklenmek isteniyorsa buraya eklenmesi gerekiyor
                //if(Convert.ToInt32(response.StatusCode) != 200)

                string result = response.Content.ReadAsStringAsync().Result;
                return result;
            }
        }
    
        public static string PutMethod(RequestParameter model)
        {
            using (var httpClient = new HttpClient())
            {
                var data = new System.Net.Http.StringContent(model.Data, Encoding.UTF8, "application/json");

                HttpResponseMessage response = httpClient.PutAsync(model.Url, data).Result;

                //Log Eklenmek isteniyorsa buraya eklenmesi gerekiyor
                //if(Convert.ToInt32(response.StatusCode) != 200)

                string result = response.Content.ReadAsStringAsync().Result;
                return result;
            }
        }

        public static string DeleteMethod(RequestParameter model)
        {
            using (var httpClient = new HttpClient())
            {
                //var data = new System.Net.Http.StringContent(model.Data, Encoding.UTF8, "application/json");

                HttpResponseMessage response = httpClient.DeleteAsync(model.Url).Result;

                //Log Eklenmek isteniyorsa buraya eklenmesi gerekiyor
                //if(Convert.ToInt32(response.StatusCode) != 200)

                string result = response.Content.ReadAsStringAsync().Result;
                return result;
            }
        }
    }
}

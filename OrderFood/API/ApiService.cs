using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OnlineFood.Core;
using OnlineFood.Core.Domain;

namespace OrderFood.API
{
    public class ApiService
    {
        // Define an event to handle API responses
        public static event Action<RestResponse> ApiResponseReceived;

        public static async Task<ApiResponse<T>> callAPI<T>(string action, Method method, Dictionary<string, string> parameter, string body)
        {
            ApiResponse<T> result;
            try
            {
                string strURL = "https://localhost:44306/";
                RestClient client = new RestClient(strURL);
                var request = new RestRequest(action, method);
                if(parameter != null)
                {
                    foreach (var pr in parameter)
                    {
                        request.AddParameter(pr.Key, pr.Value.ToString());
                    }
                }    
                
                if (!string.IsNullOrWhiteSpace(body))
                {
                    request.AddBody(body);
                }
                RestResponse res = client.Execute(request);
                if (res.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    result = JsonConvert.DeserializeObject<ApiResponse<T>>(res.Content);
                }
                else
                {
                    result = new ApiResponse<T>(res.StatusCode, res.ErrorMessage, default(T));
                }
            }
            catch (Exception ex)
            {
                // Log the error
                result = new ApiResponse<T>(System.Net.HttpStatusCode.ExpectationFailed, ex.Message, default(T));
            }
            return result;
        }
    }
}

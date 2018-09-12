using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using DemoConsumirAPI.Model;
using Newtonsoft;
using Newtonsoft.Json;

namespace DemoConsumirAPI.Services
{
    class Proxy : IProxy
    {
        //Base Address
        string BaseAdress = "http://10.15.3.116:5000";

        public async Task<T> SendGet<T>(string requestURI)
        {
            T Result = default(T);
            using (var Client = new HttpClient())
            {
                try
                {
                    //URL Final/Absoluta
                    requestURI = BaseAdress + requestURI;

                    Client.DefaultRequestHeaders.Accept.Clear();
                    Client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                    var ResultJSON = await Client.GetStringAsync(requestURI);
                    Result = JsonConvert.DeserializeObject<T>(ResultJSON);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }
            return Result;
        }

        #region MembersOfIProxy
        public async Task<List<Pie>> GetAllPies()
        {
            return await SendGet<List<Pie>>("/api/catalog/pies");
        }
        public List<Pie> GetAllPiesAsync()
        {
            List<Pie> Result = null;
            Task.Run(async () => Result = await GetAllPies()).Wait();
            return Result;
        }

        public async Task<Pie> GetPieById(int ID)
        {
            return await SendGet<Pie>($"/api/catalog/pies/{ID}");
        }

        public async Task<List<Pie>> GetPiesOfTheWeek()
        {
            List<Pie> Result = null;

            var RT = await SendGet<List<Pie>>("/api/catalog/PiesOfTheWeek/");
            Result = RT.FindAll(p => p.IsPieOfTheWeek = true);
            return Result;
        } 
        #endregion
    }
}

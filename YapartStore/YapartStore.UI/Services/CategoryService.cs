using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using YapartStore.UI.Models;
using YapartStore.UI.Services.Base;

namespace YapartStore.UI.Services
{
    public class CategoryService : ICategoryService
    {
        public async Task<List<CategoryModel>> GetCategories()
        {
            try
            {
                string url = ConfigurationManager.AppSettings["WebApiUrl"];
                HttpWebRequest request = (HttpWebRequest)WebRequest
                    .Create(url + "/category/GetCategories");
                request.ContentType = "application/json; charset=utf-8";
                request.Method = "GET";

                using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    return JsonConvert.DeserializeObject<List<CategoryModel>>(await reader.ReadToEndAsync());
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
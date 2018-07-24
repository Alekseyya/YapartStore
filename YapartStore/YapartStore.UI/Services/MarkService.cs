using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using YapartStore.UI.Services.Base;
using YapartStore.UI.ViewModels;

namespace YapartStore.UI.Services
{
    public class MarkService : IMarkService
    {
        public async Task<List<MarkViewModel>> GetAllMarks()
        {
            try
            {
                string url = ConfigurationManager.AppSettings["WebApiUrl"];
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + "/mark/GetAllMarks");
                request.ContentType = "application/json; charset=utf-8";
                request.Method = "GET";

                using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    return JsonConvert.DeserializeObject<List<MarkViewModel>>(await reader.ReadToEndAsync());
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
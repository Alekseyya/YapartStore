
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
    public class ModificationService : IModificationService
    {
        public async Task<List<ModificationViewModel>> GetModificationByModelName(string modelName)
        {
            try
            {
                string url = ConfigurationManager.AppSettings["WebApiUrl"];
                HttpWebRequest request = (HttpWebRequest)WebRequest
                    .Create(url + "/modification/GetModificationsByModelName?modelName=" + modelName);
                request.ContentType = "application/json; charset=utf-8";
                request.Method = "GET";

                using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    return JsonConvert.DeserializeObject<List<ModificationViewModel>>(await reader.ReadToEndAsync());
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
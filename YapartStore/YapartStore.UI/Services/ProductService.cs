using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using YapartStore.UI.Services.Base;
using YapartStore.UI.ViewModels;

namespace YapartStore.UI.Services
{
    public class ProductService : IProductService
    {
        public async Task<List<ProductViewModel>> GetAllProducts()
        {
            try
            {
                string url = ConfigurationManager.AppSettings["WebApiUrl"];
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + "/product/GetProducts");
                request.ContentType = "application/json; charset=utf-8";
                request.Method = "GET";
                
                using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    return JsonConvert.DeserializeObject<List<ProductViewModel>>(await reader.ReadToEndAsync());
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public async Task<List<ProductViewModel>> GetProductsOfBrand(string brand)
        {
            try
            {
                string url = ConfigurationManager.AppSettings["WebApiUrl"];
                HttpWebRequest request = (HttpWebRequest)WebRequest
                    .Create(url + "/product/GetProductsOfBrand?brand=" + brand);
                request.ContentType = "application/json; charset=utf-8";
                request.Method = "GET";

                using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    return JsonConvert.DeserializeObject<List<ProductViewModel>>(await reader.ReadToEndAsync());
                }
            }
            catch (Exception e)
            {
                throw e;
            }

        }

        public async Task<List<ProductViewModel>> GetAllCaps()
        {
            try
            {
                string url = ConfigurationManager.AppSettings["WebApiUrl"];
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + "/product/GetAllCaps");
                request.ContentType = "application/json; charset=utf-8";
                request.Method = "GET";

                using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    return JsonConvert.DeserializeObject<List<ProductViewModel>>(await reader.ReadToEndAsync());
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<ProductViewModel>> GetSizeOfCaps(int size)
        {
            try
            {
                string url = ConfigurationManager.AppSettings["WebApiUrl"];
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + "/product/GetSizeCaps?=" + size.ToString());
                request.ContentType = "application/json; charset=utf-8";
                request.Method = "GET";

                using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    return JsonConvert.DeserializeObject<List<ProductViewModel>>(await reader.ReadToEndAsync());
                }
                return null;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<ProductViewModel> GetProductByArticle(string article)
        {
            try
            {
                string url = ConfigurationManager.AppSettings["WebApiUrl"];
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url + "/product/GetProductByArticle?article=" + article);
                request.ContentType = "application/json; charset=utf-8";
                request.Method = "GET";

                using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    return JsonConvert.DeserializeObject<ProductViewModel>(await reader.ReadToEndAsync());
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
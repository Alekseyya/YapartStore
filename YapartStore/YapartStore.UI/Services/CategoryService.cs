using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using Newtonsoft.Json;
using YapartStore.UI.Models;
using YapartStore.UI.Services.Base;
using YapartStore.UI.ViewModels;

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


        public async Task<List<CategoryViewModel>> MappingCategoryModelToViewModel(List<CategoryModel> categories)
        {
            return await Task.Run(() => {
                var list = new List<CategoryViewModel>();
                foreach (var category in categories)
                {
                    list.Add(new CategoryViewModel()
                    {
                        Id = category.Id,
                        Name = category.Name,
                        Show = category.Show,
                        EnglishName = category.EnglishName
                    });
                }
                return list;
            });
        }

        public async Task<CategoryViewModel> GetCategoryByName(string categoryName)
        {
            try
            {
                string url = ConfigurationManager.AppSettings["WebApiUrl"];
                HttpWebRequest request = (HttpWebRequest)WebRequest
                    .Create(url + "/category/GetCategoryByName?categoryName=" + categoryName);
                request.ContentType = "application/json; charset=utf-8";
                request.Method = "GET";

                using (HttpWebResponse response = (HttpWebResponse)await request.GetResponseAsync())
                using (Stream stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                {
                    return JsonConvert.DeserializeObject<CategoryViewModel>(await reader.ReadToEndAsync());
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
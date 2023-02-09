using AddIdentityWasm.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace AddIdentityWasm.Client.Services
{
    public class subCategoryService : IsubCategoryService
    {
        private readonly HttpClient _httpClient;
        public subCategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<subCategory>> getAllsubCategories()
        {
            //var response = await _httpClient.PostAsJsonAsync("api/accounts", 
            var response = await _httpClient.GetFromJsonAsync<List<subCategory>>("api/SubCategories");
            return response;
        }

        public async Task updatesubCategory(subCategory model)
        {
            //var response = await _httpClient.PostAsJsonAsync("api/accounts", "");
            //return await response.Content.ReadFromJsonAsync<ProductModel>();
            var response = await _httpClient.PostAsJsonAsync<subCategory>("api/SubCategories/", model);// ("api/Products");
            return;
        }
        public async Task addsubCategory(subCategory model)
        {
            //var response = await _httpClient.PostAsJsonAsync("api/accounts", "");
            //return await response.Content.ReadFromJsonAsync<ProductModel>();
            var response = await _httpClient.PostAsJsonAsync<subCategory>("api/SubCategories/Add", model);// ("api/Products");
            return;
        }

        public async Task deletesubCategory(subCategory model)
        {
            //var response = await _httpClient.PostAsJsonAsync("api/accounts", "");
            //return await response.Content.ReadFromJsonAsync<ProductModel>();

            var response = await _httpClient.PostAsJsonAsync("api/SubCategories/Delete", model);// ("api/Products");
            return;
        }
        //getAllCategories
        //public async Task<List<Category>> getAllCategories()
        //{
        //    //var response = await _httpClient.PostAsJsonAsync("api/accounts", "");
        //    //return await response.Content.ReadFromJsonAsync<ProductModel>();
        //    var response = await _httpClient.GetFromJsonAsync<List<Category>>("api/Categories");
        //    return response;
        //}
    }
}

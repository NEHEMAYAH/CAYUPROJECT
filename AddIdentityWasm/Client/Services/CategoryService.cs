using AddIdentityWasm.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace AddIdentityWasm.Client.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _httpClient;
        public CategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        //getAllCategories
        public async Task<List<Category>> getAllCategories()
        {
            //var response = await _httpClient.PostAsJsonAsync("api/accounts", "");
            //return await response.Content.ReadFromJsonAsync<ProductModel>();
            var response = await _httpClient.GetFromJsonAsync<List<Category>>("api/Categories");
            return response;
        }
        public async Task updateCategory(Category model)
        {
            //var response = await _httpClient.PostAsJsonAsync("api/accounts", "");
            //return await response.Content.ReadFromJsonAsync<ProductModel>();
            var response = await _httpClient.PostAsJsonAsync<Category>("api/Categories/", model);// ("api/Products");
            return;
        }
        public async Task addCategory(Category model)
        {
            //var response = await _httpClient.PostAsJsonAsync("api/accounts", "");
            //return await response.Content.ReadFromJsonAsync<ProductModel>();
            var response = await _httpClient.PostAsJsonAsync<Category>("api/Categories/Add", model);// ("api/Products");
            return;
        }

        public async Task deleteOrder(Category model)
        {
            //var response = await _httpClient.PostAsJsonAsync("api/accounts", "");
            //return await response.Content.ReadFromJsonAsync<ProductModel>();

            var response = await _httpClient.PostAsJsonAsync("api/Categories/Delete", model);// ("api/Products");
            return;
        }
        
}
}

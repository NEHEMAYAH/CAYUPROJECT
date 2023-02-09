using AddIdentityWasm.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace AddIdentityWasm.Client.Services
{
    public class ProdModelService : IProdModelService
    {
        private readonly HttpClient _httpClient;
        public ProdModelService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ProductModel>> getAllProducts()
        {
            //var response = await _httpClient.PostAsJsonAsync("api/accounts", "");
            //return await response.Content.ReadFromJsonAsync<ProductModel>();
            var response = await _httpClient.GetFromJsonAsync<List<ProductModel>>("api/Products");
            return response;
        }

        public async Task updateProduct(ProductModel prod)
        {
            //var response = await _httpClient.PostAsJsonAsync("api/accounts", "");
            //return await response.Content.ReadFromJsonAsync<ProductModel>();
            var response = await _httpClient.PostAsJsonAsync<ProductModel>("api/Products/", prod);// ("api/Products");
            return ;
        }
        public async Task addProduct(ProductModel prod)
        {
            //var response = await _httpClient.PostAsJsonAsync("api/accounts", "");
            //return await response.Content.ReadFromJsonAsync<ProductModel>();
            var response = await _httpClient.PostAsJsonAsync<ProductModel>("api/Products/Add", prod);// ("api/Products");
            return;
        }

        public async Task deleteProduct(ProductModel prod)
        {
            //var response = await _httpClient.PostAsJsonAsync("api/accounts", "");
            //return await response.Content.ReadFromJsonAsync<ProductModel>();
           
            var response = await _httpClient.PostAsJsonAsync("api/Products/Delete", prod);// ("api/Products");
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

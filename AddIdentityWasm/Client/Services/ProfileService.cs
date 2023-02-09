using AddIdentityWasm.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace AddIdentityWasm.Client.Services
{
    public class ProfileService : IProfileService
    {
        private readonly HttpClient _httpClient;
        public ProfileService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<Customer>> getAllCustomers()
        {
            //var response = await _httpClient.PostAsJsonAsync("api/accounts", "");
            //return await response.Content.ReadFromJsonAsync<ProductModel>();
            var response = await _httpClient.GetFromJsonAsync<List<Customer>>("api/Customer");
            return response;
        }

        public async Task updateCustomer(Customer custm)
        {
            //var response = await _httpClient.PostAsJsonAsync("api/accounts", "");
            //return await response.Content.ReadFromJsonAsync<ProductModel>();
            var response = await _httpClient.PostAsJsonAsync<Customer>("api/Customer/", custm);// ("api/Products");
            return;
        }
        public async Task addCustomer(Customer custm)
        {
            //var response = await _httpClient.PostAsJsonAsync("api/accounts", "");
            //return await response.Content.ReadFromJsonAsync<ProductModel>();
            var response = await _httpClient.PostAsJsonAsync<Customer>("api/Customer/Add", custm);// ("api/Products");
            return;
        }

        public async Task deleteCustomer(Customer custm)
        {
            //var response = await _httpClient.PostAsJsonAsync("api/accounts", "");
            //return await response.Content.ReadFromJsonAsync<ProductModel>();

            var response = await _httpClient.PostAsJsonAsync("api/Customer/Delete", custm);// ("api/Products");
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

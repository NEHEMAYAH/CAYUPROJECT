using AddIdentityWasm.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace AddIdentityWasm.Client.Services
{
    public class OrderService : IOrderService
    {
        private readonly HttpClient _httpClient;
        public OrderService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<ShippingOrder>> getAllOrders()
        {
            //var response = await _httpClient.PostAsJsonAsync("api/accounts", "");
            //return await response.Content.ReadFromJsonAsync<ProductModel>();
            var response = await _httpClient.GetFromJsonAsync<List<ShippingOrder>>("api/Order");
            return response;
        }

        public async Task updateOrder(ShippingOrder model)
        {
            //var response = await _httpClient.PostAsJsonAsync("api/accounts", "");
            //return await response.Content.ReadFromJsonAsync<ProductModel>();
            var response = await _httpClient.PostAsJsonAsync<ShippingOrder>("api/Order/", model);// ("api/Products");
            return;
        }
        public async Task addOrder(ShippingOrder model)
        {
            //var response = await _httpClient.PostAsJsonAsync("api/accounts", "");
            //return await response.Content.ReadFromJsonAsync<ProductModel>();
            var response = await _httpClient.PostAsJsonAsync<ShippingOrder>("api/Order/Add", model);// ("api/Products");
            return;
        }

        public async Task deleteOrder(ShippingOrder model)
        {
            //var response = await _httpClient.PostAsJsonAsync("api/accounts", "");
            //return await response.Content.ReadFromJsonAsync<ProductModel>();

            var response = await _httpClient.PostAsJsonAsync("api/Order/Delete", model);// ("api/Products");
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

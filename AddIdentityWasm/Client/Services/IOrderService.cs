using AddIdentityWasm.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AddIdentityWasm.Client.Services
{
    public interface IOrderService
    {
        Task addOrder(ShippingOrder custm);
        Task deleteOrder(ShippingOrder custm);
        Task<List<ShippingOrder>> getAllOrders();
        Task updateOrder(ShippingOrder model);
    }
}
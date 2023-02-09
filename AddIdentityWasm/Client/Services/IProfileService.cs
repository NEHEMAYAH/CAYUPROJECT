using AddIdentityWasm.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AddIdentityWasm.Client.Services
{
    public interface IProfileService
    {
        Task addCustomer(Customer custm);
        Task deleteCustomer(Customer custm);
        Task<List<Customer>> getAllCustomers();
        Task updateCustomer(Customer custm);
    }
}
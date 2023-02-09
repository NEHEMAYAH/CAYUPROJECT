using AddIdentityWasm.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AddIdentityWasm.Client.Services
{
    public interface ICategoryService
    {
        Task addCategory(Category model);
        Task deleteOrder(Category model);
        Task<List<Category>> getAllCategories();
        Task updateCategory(Category model);
    }
}
using AddIdentityWasm.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AddIdentityWasm.Client.Services
{
    public interface IsubCategoryService
    {
        Task addsubCategory(subCategory model);
        Task deletesubCategory(subCategory model);
        Task<List<subCategory>> getAllsubCategories();
        Task updatesubCategory(subCategory model);
    }
}
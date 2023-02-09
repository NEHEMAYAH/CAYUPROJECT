using AddIdentityWasm.Shared;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AddIdentityWasm.Client.Services
{
    public interface IProdModelService
    {
        Task addProduct(ProductModel prod);
        Task deleteProduct(ProductModel prod);

        // Task<ProductModel> getAllProducts();
        Task<List<ProductModel>> getAllProducts();
        Task updateProduct(ProductModel prod);
        //Task<List<Category>> getAllCategories();
    }
}
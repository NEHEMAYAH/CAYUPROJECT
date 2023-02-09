using AddIdentityWasm.Server.Interfaces;
using AddIdentityWasm.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddIdentityWasm.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public ProductsController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        [HttpGet]
        public async Task<ActionResult<List<ProductModel>>> getAllProducts()  
        {
             var ListofProducts = _unitOfWork.ProductRepository.GetAll(); // IENumerable<Model>
            //IEnumerable<ProductModel> prodModel = from x in result.Cast<ProductModel>() select x;
            List<ProductModel> prodModel = ListofProducts.Select(p =>
                new ProductModel
                {
                    categoryId = p.categoryId,
                    product_name = p.product_name,
                    productId = p.productId,
                    productPrice = p.productPrice,
                    productUrl = p.productUrl
                }).ToList();
            return Ok(prodModel);
        }

        [HttpPost]
        public IActionResult updateProduct(ProductModel prod)
        {
            Product product = new Product()
            {
                categoryId = prod.categoryId,
                 productId = prod.productId,
                 productPrice = prod.productPrice,
                  productUrl = prod.productUrl,
                   product_name = prod.product_name
            };
            _unitOfWork.ProductRepository.Update(product);
            _unitOfWork.ProductRepository.Complete();
            //var value = _unitOfWork.ProductRepository.Complete();
            // IENumerable<Model>
            //IEnumerable<ProductModel> prodModel = from x in result.Cast<ProductModel>() select x;

            return Ok();
        }
        [HttpPost("Add")]
        [Route("api/Products/Add")]
        public  IActionResult AddProduct(ProductModel prod)
        {
            Product product = new Product()
            {
                //categoryId = prod.categoryId,
                productId = prod.productId,
                productPrice = prod.productPrice,
                productUrl = prod.productUrl,
                product_name = prod.product_name
            };

            _unitOfWork.ProductRepository.AddAsync(product);
            _unitOfWork.ProductRepository.Complete();
            //var value = _unitOfWork.ProductRepository.Complete();
            // IENumerable<Model>
            //IEnumerable<ProductModel> prodModel = from x in result.Cast<ProductModel>() select x;

            return Ok();
        }
        
        [HttpPost("Delete")]
       // [Route("api/Products/{id:int}")]
       // [Route("api/Products/{id:int}")]
        public IActionResult deleteProduct(ProductModel prod)
        {

            Product product = new Product()
            {
                //categoryId = prod.categoryId,
                productId = prod.productId,
                productPrice = prod.productPrice,
                productUrl = prod.productUrl,
                product_name = prod.product_name
            };
            int id = product.productId;
            Product _prod = _unitOfWork.ProductRepository.GetById(id);
            
            _unitOfWork.ProductRepository.Remove(_prod);
             _unitOfWork.ProductRepository.Complete();
            // IENumerable<Model>
            //IEnumerable<ProductModel> prodModel = from x in result.Cast<ProductModel>() select x;

            return Ok();
        }

    }
}

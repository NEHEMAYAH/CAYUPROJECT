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
    public class CategoriesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoriesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task<ActionResult<List<Category>>> getAllCategories()
        {
            var ListofCategoriess = _unitOfWork.CategoryRepository.GetAll(); 
           
            return Ok(ListofCategoriess);
        }
        [HttpPost]
        public IActionResult updateCategory(Category model)
        {

            _unitOfWork.CategoryRepository.Update(model);
            _unitOfWork.CategoryRepository.Complete();
            //var value = _unitOfWork.ProductRepository.Complete();
            // IENumerable<Model>
            //IEnumerable<ProductModel> prodModel = from x in result.Cast<ProductModel>() select x;

            return Ok();
        }
        [HttpPost("Add")]
        //[Route("api/Customers/Add")]
        public IActionResult AddCategories(Category model)
        {
            // to aviod the set identity error in efcore
            Category _cust = new Category { name = model.name,  type = model.type };

            _unitOfWork.CategoryRepository.AddAsync(_cust);
            _unitOfWork.CategoryRepository.Complete();
            //var value = _unitOfWork.ProductRepository.Complete();
            // IENumerable<Model>
            //IEnumerable<ProductModel> prodModel = from x in result.Cast<ProductModel>() select x;

            return Ok();
        }

        [HttpPost("Delete")]
        // [Route("api/Products/{id:int}")]
        // [Route("api/Products/{id:int}")]
        public IActionResult deleteOrders(Category model)
        {

            int id = model.categoryId;
            Category _model = _unitOfWork.CategoryRepository.GetById(id);

            _unitOfWork.CategoryRepository.Remove(_model);
            _unitOfWork.CategoryRepository.Complete();
            // IENumerable<Model>
            //IEnumerable<ProductModel> prodModel = from x in result.Cast<ProductModel>() select x;

            return Ok();
        }

    }
}

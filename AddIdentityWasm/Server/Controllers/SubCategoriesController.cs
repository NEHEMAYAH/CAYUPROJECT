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
    public class SubCategoriesController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public SubCategoriesController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public async Task<ActionResult<List<subCategory>>> getAllCategories()
        {
            var ListofCategoriess = _unitOfWork.subCategoryRepository.GetAll(); 
           
            return Ok(ListofCategoriess);
        }
        [HttpPost]
        public IActionResult updateCategory(subCategory model)
        {

            _unitOfWork.subCategoryRepository.Update(model);
            _unitOfWork.subCategoryRepository.Complete();
            //var value = _unitOfWork.ProductRepository.Complete();
            // IENumerable<Model>
            //IEnumerable<ProductModel> prodModel = from x in result.Cast<ProductModel>() select x;

            return Ok();
        }
        [HttpPost("Add")]
        //[Route("api/Customers/Add")]
        public IActionResult AddsubCategories(subCategory model)
        {
            // to aviod the set identity error in efcore
            subCategory _cust = new subCategory { name = model.name,  type = model.type };

            _unitOfWork.subCategoryRepository.AddAsync(_cust);
            _unitOfWork.subCategoryRepository.Complete();
            //var value = _unitOfWork.ProductRepository.Complete();
            // IENumerable<Model>
            //IEnumerable<ProductModel> prodModel = from x in result.Cast<ProductModel>() select x;

            return Ok();
        }

        [HttpPost("Delete")]
        // [Route("api/Products/{id:int}")]
        // [Route("api/Products/{id:int}")]
        public IActionResult deletesubCategories(subCategory model)
        {

            int id = model.subCategoryId;
            subCategory _model = _unitOfWork.subCategoryRepository.GetById(id);

            _unitOfWork.subCategoryRepository.Remove(_model);
            _unitOfWork.subCategoryRepository.Complete();
            // IENumerable<Model>
            //IEnumerable<ProductModel> prodModel = from x in result.Cast<ProductModel>() select x;

            return Ok();
        }

    }
}

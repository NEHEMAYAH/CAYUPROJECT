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
    public class CustomerController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public CustomerController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        [HttpGet]
        public async Task<ActionResult<List<Customer>>> getAllCustomers()  
        {
             var ListofCustomers = _unitOfWork.CustomerRepository.GetAll(); // IENumerable<Model>
            //IEnumerable<ProductModel> prodModel = from x in result.Cast<ProductModel>() select x;
           
            return Ok(ListofCustomers);
        }

        [HttpPost]
        public IActionResult updateCustomer(Customer model)
        {
           
            _unitOfWork.CustomerRepository.Update(model);
            _unitOfWork.CustomerRepository.Complete();
            //var value = _unitOfWork.ProductRepository.Complete();
            // IENumerable<Model>
            //IEnumerable<ProductModel> prodModel = from x in result.Cast<ProductModel>() select x;

            return Ok();
        }
        [HttpPost("Add")]
        //[Route("api/Customers/Add")]
        public  IActionResult AddCustomer(Customer model)
        {
            // to aviod the set identity error in efcore
            Customer _cust = new Customer { name = model.name, contact = model.contact, address = model.contact };
            
            _unitOfWork.CustomerRepository.AddAsync(_cust);
            _unitOfWork.CustomerRepository.Complete();
            //var value = _unitOfWork.ProductRepository.Complete();
            // IENumerable<Model>
            //IEnumerable<ProductModel> prodModel = from x in result.Cast<ProductModel>() select x;

            return Ok();
        }
        
        [HttpPost("Delete")]
       // [Route("api/Products/{id:int}")]
       // [Route("api/Products/{id:int}")]
        public IActionResult deleteCustomer(Customer model)
        {

            int id = model.customerId;
            Customer _model = _unitOfWork.CustomerRepository.GetById(id);
            
            _unitOfWork.CustomerRepository.Remove(_model);
             _unitOfWork.CustomerRepository.Complete();
            // IENumerable<Model>
            //IEnumerable<ProductModel> prodModel = from x in result.Cast<ProductModel>() select x;

            return Ok();
        }

    }
}

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
    public class OrderController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;

        public OrderController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }


        [HttpGet]
        public async Task<ActionResult<List<ShippingOrder>>> getAllOrders()  
        {
             var ListofOrders = _unitOfWork.OrderRepository.GetAll(); // IENumerable<Model>
            //IEnumerable<ProductModel> prodModel = from x in result.Cast<ProductModel>() select x;
           
            return Ok(ListofOrders);
        }

        [HttpPost]
        public IActionResult updateOrders(ShippingOrder model)
        {
           
            _unitOfWork.OrderRepository.Update(model);
            _unitOfWork.OrderRepository.Complete();
            //var value = _unitOfWork.ProductRepository.Complete();
            // IENumerable<Model>
            //IEnumerable<ProductModel> prodModel = from x in result.Cast<ProductModel>() select x;

            return Ok();
        }
        [HttpPost("Add")]
        //[Route("api/Customers/Add")]
        public  IActionResult AddOrders(ShippingOrder model)
        {
            // to aviod the set identity error in efcore
            ShippingOrder _cust = new ShippingOrder {  customerId = model.customerId, date = model.date };
            
            _unitOfWork.OrderRepository.AddAsync(_cust);
            _unitOfWork.OrderRepository.Complete();
            //var value = _unitOfWork.ProductRepository.Complete();
            // IENumerable<Model>
            //IEnumerable<ProductModel> prodModel = from x in result.Cast<ProductModel>() select x;

            return Ok();
        }
        
        [HttpPost("Delete")]
       // [Route("api/Products/{id:int}")]
       // [Route("api/Products/{id:int}")]
        public IActionResult deleteOrders(ShippingOrder model)
        {

            int id = model.orderId;
            ShippingOrder _model = _unitOfWork.OrderRepository.GetById(id);
            
            _unitOfWork.OrderRepository.Remove(_model);
             _unitOfWork.OrderRepository.Complete();
            // IENumerable<Model>
            //IEnumerable<ProductModel> prodModel = from x in result.Cast<ProductModel>() select x;

            return Ok();
        }

    }
}

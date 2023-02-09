using AddIdentityWasm.Server.Data;
using AddIdentityWasm.Server.Interfaces;
using AddIdentityWasm.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddIdentityWasm.Server.Repo
{
  
    public class OrderRepository : GenericRepository<ShippingOrder>, IOrderRepository
    {
        public OrderRepository(ApplicationDbContext context) : base(context) { }
    }

 
}

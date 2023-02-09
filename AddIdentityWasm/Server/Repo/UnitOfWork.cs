using AddIdentityWasm.Client.Pages;
using AddIdentityWasm.Server.Data;
using AddIdentityWasm.Server.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddIdentityWasm.Server.Repo
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext context;
        public UnitOfWork(ApplicationDbContext context)
        {
            this.context = context;
            ProductRepository = new ProductRepository(this.context);
            CategoryRepository = new CategoryRepository(this.context); // cate repo
            CustomerRepository = new CustomerRepository(this.context);
            OrderRepository = new OrderRepository(this.context);
            CategoryRepository = new CategoryRepository(this.context);
            subCategoryRepository = new subCategoryRepository(this.context);

        }
        public IsubCategoryRepository subCategoryRepository
        {
            get;
            private set;
        }
        public IProductRepository ProductRepository
        {
            get;
            private set;
        }
        public ICategoryRepository CategoryRepository
        {
            get;
            private set;
        }
        public ICustomerRepository CustomerRepository
        {
            get;
            private set;
        }
        public IOrderRepository OrderRepository
        {
            get;
            private set;
        }
        // public IProductRepository ProductRepository { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Dispose()
        {
            context.Dispose();
        }
        public int save()
        {
            return context.SaveChanges();
        }
    }

    }

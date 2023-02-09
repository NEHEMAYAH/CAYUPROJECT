﻿using AddIdentityWasm.Server.Data;
using AddIdentityWasm.Server.Interfaces;
using AddIdentityWasm.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AddIdentityWasm.Server.Repo
{
  
    public class CategoryRepository : GenericRepository<Category>, ICategoryRepository
    {
        public CategoryRepository(ApplicationDbContext context) : base(context) { }
    }
}

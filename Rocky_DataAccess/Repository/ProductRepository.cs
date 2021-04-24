﻿using Microsoft.AspNetCore.Mvc.Rendering;
using Rocky_DataAccess.Repository.IRepository;
using Rocky_Models;
using Rocky_Utility;
using System.Collections.Generic;
using System.Linq;

namespace Rocky_DataAccess.Repository
{
    public class ProductRepository : Repository<Product>, IProductRepository
    {
        private readonly ApplicationDbContext _db;

        public ProductRepository(ApplicationDbContext db): base(db)
        {
            _db = db;
        }

        public void Update(Product obj)
        {
            _db.Update(obj);
        }

        public IEnumerable<SelectListItem> GetAllDropdownList(string obj)
        {
            if (obj == WC.CategoryName)
            {
                return _db.Category.Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                });
            }

            if(obj == WC.AppliationTypeName)
            {
                return _db.ApplicationType.Select(i => new SelectListItem
                {
                    Text = i.Name,
                    Value = i.Id.ToString()
                });
            }

            return null;
        }
    }
}

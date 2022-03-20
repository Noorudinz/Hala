using AdminLTE.MVC.Data;
using AdminLTE.MVC.Models;
using AdminLTE.MVC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.MVC.Implementation
{
    public class ProductRepository: IProduct
    {
        private readonly ApplicationDbContext _context;
        public ProductRepository(ApplicationDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public List<ProductList> GetAllProductList()
        {
            
            var product = (from p in _context.Product
                       join ct in _context.Category
                       on p.CategoryId equals ct.CategoryId
                       join sct in _context.SubCategory
                       on p.SubCategoryId equals sct.SubCategoryId
                       join b in _context.Brand
                       on p.BrandId equals b.BrandId
                       select new ProductList
                       {
                         Product_Id =  p.Product_Id,
                         BrandName = b.BrandName,
                         CategoryName = ct.Category_Name,
                         SubCategoryName = sct.SubCategory_Name,
                         Product_Name = p.Product_Name
                       }).ToList();

            return product;
        }
    }
}

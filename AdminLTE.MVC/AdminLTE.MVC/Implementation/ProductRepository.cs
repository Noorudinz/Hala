using AdminLTE.MVC.Data;
using AdminLTE.MVC.Models;
using AdminLTE.MVC.Repository;
using Microsoft.AspNetCore.Mvc;
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

        public AddProductNameResponse AddProduct(AddProductName productAdd)
        {
            try
            {
                var addProduct = new ProductMaster();
                if (productAdd != null && productAdd.ProductId == 0)
                {                  
                    addProduct.Product_Name = productAdd.ProductName;
                    addProduct.CategoryId = productAdd.CategoryId;
                    addProduct.SubCategoryId = productAdd.SubCategoryId;
                    addProduct.SKU = productAdd.SKU;
                    addProduct.Short_Desc = productAdd.ShortDesc;
                    addProduct.CreatedOn = DateTime.Now;

                    _context.Product.Add(addProduct);
                    _context.SaveChanges();

                    int productId = addProduct.Product_Id;
                    foreach(var color in productAdd.ColorId)
                    {
                        var prodColor = new ProductsColor();
                        prodColor.ProductId = productId;
                        prodColor.ColorId = color;
                        prodColor.IsActive = true;
                        prodColor.CreatedOn = DateTime.Now;

                        _context.ProductsColor.Add(prodColor);                       
                    }
                    _context.SaveChanges();

                    return (new AddProductNameResponse()
                    {
                        ProductId = addProduct.Product_Id,
                        Status = "Success",
                        Message = "Product Added Successfully !",
                    });
                }

                return (new AddProductNameResponse()
                {
                    ProductId = addProduct.Product_Id,
                    Status = "Failure",
                    Message = "Product Added Failed !",
                });
            }
            catch (Exception ex)
            {
                return (new AddProductNameResponse()
                {
                    ProductId = 0,
                    Status = "Failure",
                    Message = ex.ToString()
                });
            }        

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

        public ProductMaster GetProductMasterById(int productId)
        {
            return  _context.Product.Where(a => a.Product_Id == productId).FirstOrDefault();
        }
    }
}

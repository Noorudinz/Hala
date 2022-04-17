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
                    addProduct.BrandId = productAdd.BrandId;
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

        public AddProductNameResponse AddProductStockInfo(StockInformation stockInformation)
        {
            try
            {
                var product = GetProductMasterById(stockInformation.ProductId);
                if (stockInformation != null)
                {
                    var stocks = new Stocks();
                    stocks.Product_Id = stockInformation.ProductId;
                    stocks.Availablity = stockInformation.AvailStock;
                    stocks.Price = stockInformation.Price;
                    stocks.IsActive = true;
                    stocks.CreatedOn = DateTime.Now;

                    _context.Stocks.Add(stocks);
                    _context.SaveChanges();

                    product.StockId = stocks.StockId;

                    var description = new Description();
                    description.Product_Id = stockInformation.ProductId;
                    description.Description_Content = stockInformation.Description;
                    description.IsActive = true;
                    description.CreatedOn = DateTime.Now;

                    _context.Description.Add(description);
                    _context.SaveChanges();

                    product.DescId = description.DescId;

                    var specification = new Sepcification();
                    specification.Product_Id = stockInformation.ProductId;
                    specification.Weight = stockInformation.Weight;
                    specification.Dimensions = stockInformation.Dimensions;
                    specification.Size = stockInformation.Size;
                    specification.Color = stockInformation.Color;
                    specification.Guarantee = stockInformation.Guarantee;
                    specification.IsActive = true;
                    specification.CreatedOn = DateTime.Now;

                    _context.Sepcification.Add(specification);
                    _context.SaveChanges();

                    product.SpecId = specification.SpecId;

                    product.UpdatedOn = DateTime.Now;
                    _context.SaveChanges();
                }

                bool isImageExist = _context.Images.Where(s => s.Product_Id == stockInformation.ProductId).Select(p => p.IsActive).Any();
                bool isDescriptionExist = _context.Description.Where(s => s.Product_Id == stockInformation.ProductId).Select(p => p.IsActive).Any();
                bool isStockExist = _context.Stocks.Where(s => s.Product_Id == stockInformation.ProductId).Select(p => p.IsActive).Any();
                bool isSpecExist = _context.Sepcification.Where(s => s.Product_Id == stockInformation.ProductId).Select(p => p.IsActive).Any();

                if (isImageExist && isDescriptionExist && isStockExist && isSpecExist)
                {
                    var productActivation = GetProductMasterById(stockInformation.ProductId);
                    productActivation.IsActive = true;
                    product.UpdatedOn = DateTime.Now;
                    _context.SaveChanges();


                    return (new AddProductNameResponse()
                    {
                        ProductId = product.Product_Id,
                        Status = "Success",
                        Message = "Product Activated Successfully !",
                    });

                }

                return (new AddProductNameResponse()
                {
                    ProductId = product.Product_Id,
                    Status = "Information",
                    Message = "Product Added but Inactive !",
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

        public List<ProductList> GetAllActiveProductList()
        {
            
            var product = (from p in _context.Product
                       join ct in _context.Category
                       on p.CategoryId equals ct.CategoryId
                       join sct in _context.SubCategory
                       on p.SubCategoryId equals sct.SubCategoryId
                       join b in _context.Brand
                       on p.BrandId equals b.BrandId
                       where (p.IsActive == true)
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

        public List<ProductList> GetAllInActiveProductList()
        {

            var product = (from p in _context.Product
                           join ct in _context.Category
                           on p.CategoryId equals ct.CategoryId
                           join sct in _context.SubCategory
                           on p.SubCategoryId equals sct.SubCategoryId
                           join b in _context.Brand
                           on p.BrandId equals b.BrandId
                           where (p.IsActive == false)
                           select new ProductList
                           {
                               Product_Id = p.Product_Id,
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

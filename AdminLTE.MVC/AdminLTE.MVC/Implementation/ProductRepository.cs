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

        public StockInformation GetStockInfoByProdcutId(int productId)
        {
            var product = _context.Product.Where(a => a.Product_Id == productId).FirstOrDefault();

            var stock = _context.Stocks.Where(a => a.Product_Id == productId && a.StockId == product.StockId).FirstOrDefault();
            var description = _context.Description.Where(a => a.Product_Id == productId && a.DescId == product.DescId).FirstOrDefault();
            var sepecification = _context.Sepcification.Where(a => a.Product_Id == productId && a.SpecId == product.SpecId).FirstOrDefault();

            var stockInfo = new StockInformation();

            stockInfo.ProductId = product.Product_Id;
            stockInfo.AvailStock = stock == null ? 0 : stock.Availablity; 
            stockInfo.Price = stock == null ? 0 : stock.Price;
            stockInfo.Description = description == null? string.Empty : description.Description_Content;
            stockInfo.Weight = sepecification == null ? string.Empty : sepecification.Weight;
            stockInfo.Dimensions = sepecification == null ? string.Empty : sepecification.Dimensions;
            stockInfo.Size = sepecification == null ? string.Empty : sepecification.Size;
            stockInfo.Color = sepecification == null ? string.Empty : sepecification.Color;
            stockInfo.Guarantee = sepecification == null ? string.Empty : sepecification.Guarantee;

            return stockInfo;

        }

        public AddProductNameResponse UpdateProduct(EditProductMaster productUpdate)
        {
            try
            {
                int productId = productUpdate.ProductMaster.Product_Id;

                var addProduct = _context.Product.Where(a => a.Product_Id == productId).FirstOrDefault();
                if (productUpdate != null && productUpdate.ProductMaster.Product_Id > 0)
                {
                    addProduct.Product_Name = productUpdate.ProductMaster.Product_Name;
                    addProduct.CategoryId = productUpdate.ProductMaster.CategoryId;
                    addProduct.SubCategoryId = productUpdate.ProductMaster.SubCategoryId;
                    addProduct.BrandId = productUpdate.ProductMaster.BrandId;
                    addProduct.SKU = productUpdate.ProductMaster.SKU;
                    addProduct.Short_Desc = productUpdate.ProductMaster.Short_Desc;
                    addProduct.UpdatedOn = DateTime.Now;

                    _context.SaveChanges();

                    var productColor = _context.ProductsColor.Where(a => a.ProductId == productId).ToList();
                    _context.ProductsColor.RemoveRange(productColor);
                    _context.SaveChanges();

                    foreach (var color in productUpdate.ColorId)
                    {
                        var prodColor = new ProductsColor();
                        prodColor.ProductId = productId;
                        prodColor.ColorId = color;
                        prodColor.CreatedOn = DateTime.Now;

                        _context.ProductsColor.Add(prodColor);
                    }
                    _context.SaveChanges();

                    return (new AddProductNameResponse()
                    {
                        ProductId = addProduct.Product_Id,
                        Status = "Success",
                        Message = "Product Updated Successfully !",
                    });
                }

                return (new AddProductNameResponse()
                {
                    ProductId = addProduct.Product_Id,
                    Status = "Failure",
                    Message = "Product Update Failed !",
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

        public AddProductNameResponse UpdateProductStockInfo(StockInformation stockInformation)
        {
            try
            {
                var product = GetProductMasterById(stockInformation.ProductId);
                if (stockInformation != null)
                {
                    var stocks = _context.Stocks.Where(a => a.Product_Id == product.Product_Id).FirstOrDefault();
                    stocks.Product_Id = product.Product_Id;
                    stocks.Availablity = stockInformation.AvailStock;
                    stocks.Price = stockInformation.Price;
                    stocks.IsActive = true;
                    stocks.UpdatedOn = DateTime.Now;

                    _context.SaveChanges();

                    product.StockId = stocks.StockId;

                    var description = _context.Description.Where(a => a.Product_Id == product.Product_Id).FirstOrDefault();
                    description.Product_Id = product.Product_Id;
                    description.Description_Content = stockInformation.Description;
                    description.IsActive = true;
                    description.UpdatedOn = DateTime.Now;

                    _context.SaveChanges();

                    product.DescId = description.DescId;

                    var specification = _context.Sepcification.Where(a => a.Product_Id == product.Product_Id).FirstOrDefault();
                    specification.Product_Id = product.Product_Id;
                    specification.Weight = stockInformation.Weight;
                    specification.Dimensions = stockInformation.Dimensions;
                    specification.Size = stockInformation.Size;
                    specification.Color = stockInformation.Color;
                    specification.Guarantee = stockInformation.Guarantee;
                    specification.IsActive = true;
                    specification.UpdatedOn = DateTime.Now;

                    _context.SaveChanges();

                    product.SpecId = specification.SpecId;

                    product.UpdatedOn = DateTime.Now;
                    _context.SaveChanges();
                }

                bool isImageExist = _context.Images.Where(s => s.Product_Id == product.Product_Id).Select(p => p.IsActive).Any();
                bool isDescriptionExist = _context.Description.Where(s => s.Product_Id == product.Product_Id).Select(p => p.IsActive).Any();
                bool isStockExist = _context.Stocks.Where(s => s.Product_Id == product.Product_Id).Select(p => p.IsActive).Any();
                bool isSpecExist = _context.Sepcification.Where(s => s.Product_Id == product.Product_Id).Select(p => p.IsActive).Any();

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

        public List<ProductList> DeleteProductByProductId(int productId)
        {
            var prodMaster = _context.Product.Where(a => a.Product_Id == productId).FirstOrDefault();

            prodMaster.IsActive = false;
            _context.SaveChanges();

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
                               Product_Id = p.Product_Id,
                               BrandName = b.BrandName,
                               CategoryName = ct.Category_Name,
                               SubCategoryName = sct.SubCategory_Name,
                               Product_Name = p.Product_Name
                           }).ToList();

            return product;
        }
    }
}

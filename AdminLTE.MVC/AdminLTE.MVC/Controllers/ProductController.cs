using AdminLTE.MVC.Data;
using AdminLTE.MVC.Models;
using AdminLTE.MVC.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProduct _productRepo;
        private readonly IImages _imageRepo;
        private readonly ICategory _categoryRepo;
        private readonly ISubCategory _subCategoryRepo;
        private readonly IBrand _brandRepo;
        private readonly IColor _colorRepo;
        public ProductController(IProduct context, IImages imageContext, ICategory categoryContext,
            ISubCategory subCategoryContext, IBrand brandContext, IColor colorContext)
        {
            _productRepo = context;
            _imageRepo = imageContext;
            _categoryRepo = categoryContext;
            _subCategoryRepo = subCategoryContext;
            _brandRepo = brandContext;
            _colorRepo = colorContext;
        }

        public IActionResult Index()
        {
            var products = _productRepo.GetAllActiveProductList();
            ViewBag.DataSource = products;
            return View();
            //var Order = OrdersDetails.GetAllRecords();
            //ViewBag.DataSource = Order;
            //return View();
        }

        public IActionResult InactiveList()
        {
            var products = _productRepo.GetAllInActiveProductList();
            ViewBag.DataSource = products;
            return View();
        }

        public IActionResult AddPrimary()
        {
            return View();
        }

        
        [HttpGet]
        public JsonResult AddProduct(AddProductName productAdd)
        {
            var res = _productRepo.AddProduct(productAdd);

            TempData["ProductId"] = res.ProductId;
            TempData["ProductName"] = productAdd.ProductName;

            return Json(res);
        }

        [HttpGet]
        public IActionResult ImagesUpload()
        {
            ViewBag.ProductId = Convert.ToInt32(TempData["ProductId"]);
            ViewBag.ProductName = Convert.ToString(TempData["ProductName"]);

            return View();
        }

        [HttpPost]
        public IActionResult UploadImages(BrowseImage productImages)
        {          
            int productId = Convert.ToInt32(TempData["ProductId"]);
            var product = _productRepo.GetProductMasterById(productId);

            var imageUpload = _imageRepo.AddImages(productImages, product);
            return RedirectToAction("StockInfo");
        }

        [HttpGet]
        public IActionResult StockInfo()
        {
            int productId = Convert.ToInt32(TempData["ProductId"]);
            var product = _productRepo.GetProductMasterById(productId);

            ViewBag.ProductId = productId;
            ViewBag.ProductName = Convert.ToString(product.Product_Name);

            return View();
        }

        [HttpPost]
        public IActionResult StockInfo(StockInformation stockInformation)
        {
            int productId = Convert.ToInt32(TempData["ProductId"]);
            stockInformation.ProductId = productId;
            var product = _productRepo.AddProductStockInfo(stockInformation);

            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("Product/EditPrimary/{productId:int}")]
        public IActionResult EditPrimary(int productId)
        {            
            var product = _productRepo.GetProductMasterById(productId);
            var editProductMaster = new EditProductMaster();
            editProductMaster.ProductMaster = product;
            editProductMaster.ColorId = _colorRepo.GetColorByProductId(product.Product_Id);
            editProductMaster.Category = _categoryRepo.GetAllCategorys();
            editProductMaster.SubCategory = _subCategoryRepo.GetAllSubCategorysByCategoryId(product.CategoryId);
            editProductMaster.Brand = _brandRepo.GetAllBrands().ToList();
            editProductMaster.Color = _colorRepo.GetAllColors();
            return View(editProductMaster);
        }

        [HttpPost]
       public IActionResult EditPrimary(EditProductMaster productUpdate)
        {
            var res = _productRepo.UpdateProduct(productUpdate);

            TempData["ProductId"] = res.ProductId;
            TempData["ProductName"] = productUpdate.ProductMaster.Product_Name;

            return RedirectToAction("EditImagesUpload");
        }

        [HttpGet]
        public IActionResult EditImagesUpload()
        {
            int productId = Convert.ToInt32(TempData["ProductId"]);
            ViewBag.ProductId = productId;
            ViewBag.ProductName = Convert.ToString(TempData["ProductName"]);

            var browseImage = new EditBrowseImage();
            var imagesPath = _imageRepo.GetImagesByProductId(productId);

            browseImage.Main_URL = imagesPath.Main_URL;
            browseImage.URL_1 = imagesPath.URL_1;
            browseImage.URL_2 = imagesPath.URL_2;
            browseImage.URL_3 = imagesPath.URL_3;

            return View(browseImage);
        }

        [HttpPost]
        public IActionResult EditUploadImages(EditBrowseImage editBrowseImage)
        {
            int productId = Convert.ToInt32(TempData["ProductId"]);
            var product = _productRepo.GetProductMasterById(productId);

            var imageUpload = _imageRepo.UpdateImages(editBrowseImage, product);
            return RedirectToAction("EditStockInfo");
        }

        [HttpGet]
        public IActionResult EditStockInfo()
        {
            int productId = Convert.ToInt32(TempData["ProductId"]);
            var product = _productRepo.GetProductMasterById(productId);
            var stock = _productRepo.GetStockInfoByProdcutId(productId);

            ViewBag.ProductId = productId;
            ViewBag.ProductName = Convert.ToString(product.Product_Name);

            return View(stock);
        }

        [HttpPost]
        public IActionResult EditStockInfo(StockInformation stockInformation)
        {
            int productId = Convert.ToInt32(TempData["ProductId"]);
            stockInformation.ProductId = productId;
            var product = _productRepo.UpdateProductStockInfo(stockInformation);

            return RedirectToAction("Index");
        }

        [HttpGet]
        [Route("Product/DeleteConfirm/{productId:int}")]
        public IActionResult DeleteConfirm(int productId)
        {
            var productList = _productRepo.DeleteProductByProductId(productId);
            return RedirectToAction("Index");
        }
    }

}


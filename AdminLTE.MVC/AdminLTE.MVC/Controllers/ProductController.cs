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
        public ProductController(IProduct context, IImages imageContext)
        {
            _productRepo = context;
            _imageRepo = imageContext;
        }

        public IActionResult Index()
        {
            var products = _productRepo.GetAllProductList();
            ViewBag.DataSource = products;
            return View();
            //var Order = OrdersDetails.GetAllRecords();
            //ViewBag.DataSource = Order;
            //return View();
        }

        public IActionResult AddPrimary()
        {
            return View();
        }

        
        [HttpGet]
        public JsonResult AddProduct(AddProductName productAdd)
        {
            var res = _productRepo.AddProduct(productAdd);

            return Json(res);
        }

        [HttpGet]
        public IActionResult ImagesUpload()
        {
           // var productMaster = _productRepo.GetProductMasterById(productId);

            // var model = new ProductImages { ProductMaster = productMaster, BrowseImage = null };

            return View();
        }

        [HttpPost]
        public IActionResult UploadImages(ProductImages productImages)
        {
            var imageUpload = _imageRepo.AddImages(productImages);
            return null;
        }

    }

}


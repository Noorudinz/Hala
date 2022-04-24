using AdminLTE.MVC.Models;
using AdminLTE.MVC.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.MVC.Controllers
{
    public class BrandController : Controller
    {
        private readonly IBrand _brandRepo;
        public BrandController(IBrand context)
        {
            _brandRepo = context;
        }      

        [HttpGet]
        public List<Brand> GetAllBrands()
        {
            var brandList = _brandRepo.GetAllBrands()
                .Select(s => new Brand { BrandId = s.BrandId, BrandName = s.BrandName })
                .ToList();
            return brandList;
        }

        public IActionResult Index()
        {
            var brands = _brandRepo.GetAllBrands();
            ViewBag.DataSource = brands;
            return View();
        }

        [HttpPost]
        public IActionResult AddOrEditBrand(Brand brand)
        {
            var brandMaster = _brandRepo.AddOrEditCategory(brand);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public JsonResult EditBrand(int brandId)
        {
            var brandMaster = _brandRepo.GetBrandById(brandId);
            return Json(brandMaster);
        }


        [HttpGet]
        public JsonResult DeleteBrand(int brandId)
        {
            var response = _brandRepo.DeleteBrand(brandId);
            return Json(response);
        }
    }
}

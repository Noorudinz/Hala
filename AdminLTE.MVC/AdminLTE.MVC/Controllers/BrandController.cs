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
        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public List<Brand> GetAllBrands()
        {
            var brandList = _brandRepo.GetAllBrands()
                .Select(s => new Brand { BrandId = s.BrandId, BrandName = s.BrandName })
                .ToList();
            return brandList;
        }
    }
}

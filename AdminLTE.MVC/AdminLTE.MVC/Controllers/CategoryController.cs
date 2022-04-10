using AdminLTE.MVC.Models;
using AdminLTE.MVC.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.MVC.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategory _categoryRepo;
        public CategoryController(ICategory context)
        {
            _categoryRepo = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public List<Category> GetAllCategorys()
        {
            var categoryList = _categoryRepo.GetAllCategorys()
                .Select(s => new Category { CategoryId = s.CategoryId, Category_Name = s.Category_Name })
                .ToList();
            return categoryList;
        }
    }
}

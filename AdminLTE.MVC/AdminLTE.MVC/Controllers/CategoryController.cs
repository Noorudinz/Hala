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

        [HttpGet]
        public List<Category> GetAllCategorys()
        {
            var categoryList = _categoryRepo.GetAllCategorys()
                .Select(s => new Category { CategoryId = s.CategoryId, Category_Name = s.Category_Name })
                .ToList();
            return categoryList;
        }

        public IActionResult Index()
        {
            var categorys = _categoryRepo.GetAllCategorys();
            ViewBag.DataSource = categorys;
            return View();

        }

        [HttpPost]
        public IActionResult AddOrEditCategory(Category category)
        {
            var categoryMaster = _categoryRepo.AddOrEditCategory(category);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public JsonResult EditCategory(int categoryId)
        {
            var category = _categoryRepo.GetCategoryById(categoryId);         
            return Json(category);
        }

        [HttpGet]
        public IActionResult DeleteCategory(int categoryId)
        {
             _categoryRepo.DeleteCategory(categoryId);
            return RedirectToAction("Index");
        }

    }
}

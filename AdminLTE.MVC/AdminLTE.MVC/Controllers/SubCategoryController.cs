using AdminLTE.MVC.Models;
using AdminLTE.MVC.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.MVC.Controllers
{
    public class SubCategoryController : Controller
    {
        private readonly ISubCategory _subCategoryRepo;
        public SubCategoryController(ISubCategory context)
        {
            _subCategoryRepo = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public List<SubCategory> GetSubCategoryByCategoryId(int selectedId)
        {
            var subCategoryList = _subCategoryRepo.GetAllSubCategorysByCategoryId(selectedId)
                .Select(s => new SubCategory { SubCategoryId = s.SubCategoryId, CategoryId = s.CategoryId, SubCategory_Name = s.SubCategory_Name })
                .ToList();
            return subCategoryList;
        }
    }
}

using AdminLTE.MVC.Data;
using AdminLTE.MVC.Models;
using AdminLTE.MVC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.MVC.Implementation
{
    public class CategoryRepository : ICategory
    {
        private readonly ApplicationDbContext _context;

        public CategoryRepository(ApplicationDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public Category AddOrEditCategory(Category category)
        {
            var categoryMaster = new Category();
            if(category.CategoryId > 0)
            {
                categoryMaster = _context.Category.Where(a => a.CategoryId == category.CategoryId).FirstOrDefault();
                categoryMaster.Category_Name = category.Category_Name;
                categoryMaster.IsActive = true;
                categoryMaster.UpdatedOn = DateTime.Now;
                _context.SaveChanges();

                return categoryMaster;
            }

            categoryMaster.Category_Name = category.Category_Name;
            categoryMaster.IsActive = true;
            categoryMaster.CreatedOn = DateTime.Now;

            _context.Category.Add(categoryMaster);
            _context.SaveChanges();

            return categoryMaster;
        }

        public CategoryResponse DeleteCategory(int categoryId)
        {
            var category = _context.Category.Where(a => a.CategoryId == categoryId).FirstOrDefault();
            if(category != null && category.CategoryId > 0)
            {
                category.IsActive = false;
                category.UpdatedOn = DateTime.Now;
                _context.SaveChanges();

                return new CategoryResponse
                {
                    IsUpdated = true,
                    Message = "Deleted Succesfully"
                };
            }

            return new CategoryResponse
            {
                IsUpdated = false,
                Message = "Deleted Failed"
            };

        }

        public List<Category> GetAllCategorys()
        {
            return _context.Category.Where(a => a.IsActive == true).ToList();
        }

        public Category GetCategoryById(int categoryId)
        {
            return _context.Category.Where(w => w.CategoryId == categoryId).FirstOrDefault();
        }

        public Category UpdateCategory(Category category)
        {
            throw new NotImplementedException();
        }
    }
}

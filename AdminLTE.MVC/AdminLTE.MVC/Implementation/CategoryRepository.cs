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

        public Category AddCategory(Category category)
        {
            throw new NotImplementedException();
        }

        public void DeleteCategory(int categoryId)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetAllCategorys()
        {
            return _context.Category.ToList();
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

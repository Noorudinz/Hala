using AdminLTE.MVC.Data;
using AdminLTE.MVC.Models;
using AdminLTE.MVC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.MVC.Implementation
{
    public class SubCategoryRepository: ISubCategory
    {
        private readonly ApplicationDbContext _context;

        public SubCategoryRepository(ApplicationDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public SubCategory AddSubCategory(SubCategory subCategory)
        {
            throw new NotImplementedException();
        }

        public void DeleteSubCategory(int subCategoryId)
        {
            throw new NotImplementedException();
        }

        public List<SubCategory> GetAllSubCategorys()
        {
            throw new NotImplementedException();
        }

        public List<SubCategory> GetAllSubCategorysByCategoryId(int selectedId)
        {
            return _context.SubCategory.Where(w => w.CategoryId == selectedId).ToList();
        }

        public SubCategory GetSubCategoryById(int subCategoryId)
        {
            throw new NotImplementedException();
        }

        public SubCategory UpdateSubCategory(SubCategory subCategory)
        {
            throw new NotImplementedException();
        }
    }
}

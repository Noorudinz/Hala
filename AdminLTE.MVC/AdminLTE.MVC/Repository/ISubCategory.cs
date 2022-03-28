using AdminLTE.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.MVC.Repository
{
    public interface ISubCategory
    {
        List<SubCategory> GetAllSubCategorys();
        SubCategory GetSubCategoryById(int subCategoryId);
        SubCategory AddSubCategory(SubCategory subCategory);
        SubCategory UpdateSubCategory(SubCategory subCategory);
        void DeleteSubCategory(int subCategoryId);
        List<SubCategory> GetAllSubCategorysByCategoryId(int selectedId);
    }
}

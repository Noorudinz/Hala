using AdminLTE.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.MVC.Repository
{
    public interface ICategory
    {
        List<Category> GetAllCategorys();
        Category GetCategoryById(int categoryId);
        Category AddOrEditCategory(Category category);
        Category UpdateCategory(Category category);
        void DeleteCategory(int categoryId);
    }
}

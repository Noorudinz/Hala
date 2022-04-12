using AdminLTE.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.MVC.Repository
{
    public interface IProduct
    {
        List<ProductList> GetAllProductList();
        AddProductNameResponse AddProduct(AddProductName productAdd);
        ProductMaster GetProductMasterById(int productId);

    }
}

using AdminLTE.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.MVC.Repository
{
    public interface IProduct
    {
        List<ProductList> GetAllActiveProductList();
        List<ProductList> GetAllInActiveProductList();
        AddProductNameResponse AddProduct(AddProductName productAdd);
        AddProductNameResponse UpdateProduct(EditProductMaster productUpdate);
        ProductMaster GetProductMasterById(int productId);
        AddProductNameResponse AddProductStockInfo(StockInformation stockInformation);

    }
}

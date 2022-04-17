using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.MVC.Models
{
    public class ProductMaster
    {
        [Key]
        public int Product_Id { get; set;  }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public string Product_Name { get; set; }
        public string Short_Desc { get; set; }
        public string SKU { get; set; }
        public int ImagesId { get; set; }
        public int StockId { get; set; }
        public int DescId { get; set; }
        public int SpecId { get; set; }
        public int ReviewId { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

    }

    public class ListProductMaster
    {
        public List<ProductMaster> listProductMaster { get; set; }
    }

    public class ProductList
    {
        public int Product_Id { get; set; }
        public string BrandName { get; set; }
        public string CategoryName { get; set; }
        public string SubCategoryName { get; set; }
        public string Product_Name { get; set; }
    }

    public class AddProductName
    {
        public int ProductId { get; set; }   
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public int BrandId { get; set; }
        public int[] ColorId { get; set; }
        public string SKU { get; set; }     
        public string ProductName { get; set; }
        public string ShortDesc { get; set; }
    }

    public class AddProductNameResponse
    {
        public int ProductId { get; set; }
        public string Status { get; set; }
        public string Message { get; set; }

    }

    public class StockInformation
    {
        public int ProductId { get; set; }
        public int AvailStock { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public string Weight { get; set; }
        public string Dimensions { get; set; }            
        public string Size { get; set; }
        public string Color { get; set; }
        public string Guarantee { get; set; }

    }

    public class EditProductMaster
    {
        public ProductMaster ProductMaster { get; set; }
        public List<Category> Category { get; set; }
        public List<SubCategory> SubCategory { get; set; }
        public List<Brand> Brand { get; set; }
        public List<Color> Color { get; set; }
    }
}

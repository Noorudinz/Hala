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
        public int ColorId { get; set; }
        public string? Product_Name { get; set; }
        public string? Short_Desc { get; set; }
        public string? SKU { get; set; }
        public int ImagesId { get; set; }
        public int StockId { get; set; }
        public int DescId { get; set; }
        public int SpecId { get; set; }
        public int ReviewId { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }

    }

    public class ListProductMaster
    {
        public List<ProductMaster> listProductMaster { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.MVC.Models
{
    public class ProductsColor
    {
        [Key]
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ColorId { get; set; }
        public DateTime? CreatedOn { get; set; }

    }
}

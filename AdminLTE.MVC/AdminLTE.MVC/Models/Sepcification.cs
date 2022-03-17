using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.MVC.Models
{
    public class Sepcification
    {
        [Key]
        public int SpecId { get; set; }
        public int Product_Id { get; set; }
        public string Weight { get; set; }
        public string Dimensions { get; set; }
        public string Size { get; set; }
        public string Color { get; set; }
        public string Guarantee { get; set; }
        public string Brand { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}

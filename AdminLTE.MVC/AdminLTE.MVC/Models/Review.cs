using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.MVC.Models
{
    public class Review
    {
        [Key]
        public int ReviewId { get; set; }
        public int Product_Id { get; set; }
        public string Review_Post { get; set; }
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int Stars { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}

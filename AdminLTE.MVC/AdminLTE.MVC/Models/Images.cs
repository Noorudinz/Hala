using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.MVC.Models
{
    public class Images
    {
        [Key]
        public int ImagesId { get; set; }
        public int Product_Id { get; set; }
        public string Main_URL { get; set; }
        public string URL_1 { get; set; }
        public string URL_2 { get; set; }
        public string URL_3 { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}

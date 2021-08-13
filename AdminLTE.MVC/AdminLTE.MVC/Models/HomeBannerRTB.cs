using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace AdminLTE.MVC.Models
{
    public class HomeBannerRTB
    {
        [Key]
        public int ContentId { get; set; }
        public string ContentType { get; set; }
        public string ContentTitle { get; set; }
        public string ContentDetails { get; set; }
        public int Orders { get; set; }
        public bool IsActive { get; set; }
        public DateTime? CreatedOn { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}

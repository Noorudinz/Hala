using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.MVC.Models
{
    public class CustomerMaster
    {
        [Key]
        public Int64 CustomerId { get; set; }       
        public string CustomerName { get; set; }
        public string Email { get; set; }
        public string? Phone { get; set; }
        public int? AddressId { get; set; }
        public string? UserType { get; set; }
        public bool IsActive { get; set; }
        public string Password { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }


}

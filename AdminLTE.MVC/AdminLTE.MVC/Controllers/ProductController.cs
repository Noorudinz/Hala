using AdminLTE.MVC.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.MVC.Controllers
{
    public class ProductController : Controller
    {
        private ApplicationDbContext _context;
        public ProductController(ApplicationDbContext context)
        {
            _context = context;

        }

        public IActionResult Index()
        {
            var productData = (from product in _context.Product
                               select product);
            try
            {
                var draw = HttpContext.Request.Form["draw"].FirstOrDefault();           
                var start = Request.Form["start"].FirstOrDefault();        
                var length = Request.Form["length"].FirstOrDefault();  
                var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();              
                var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();      
                var searchValue = Request.Form["search[value]"].FirstOrDefault();

                int pageSize = length != null ? Convert.ToInt32(length) : 0;
                int skip = start != null ? Convert.ToInt32(start) : 0;
                int recordsTotal = 0;

                //var productData = (from product in _context.Product
                //                   select product);

                //Sorting  
                if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
                {
                    //customerData = customerData.OrderBy(sortColumn + " " + sortColumnDirection);
                }
                //Search  
                if (!string.IsNullOrEmpty(searchValue))
                {
                    productData = productData.Where(m => m.Product_Name == searchValue);
                }

                //total number of rows count   
                recordsTotal = productData.Count();
                //Paging   
                var data = productData.Skip(skip).Take(pageSize).ToList();
                //Returning Json Data  
                return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data });

            }
            catch (Exception)
            {
                throw;
            }

            //return View();
        }
    }
}

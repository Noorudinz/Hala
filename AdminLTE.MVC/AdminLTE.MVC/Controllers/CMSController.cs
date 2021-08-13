using AdminLTE.MVC.Data;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.MVC.Controllers
{
    public class CMSController : Controller
    {
        private ApplicationDbContext _context;
        public CMSController(ApplicationDbContext context)
        {            
            _context = context;           

        }
        public IActionResult LoadData()
        {
            try
            {
                var draw = HttpContext.Request.Form["draw"].FirstOrDefault();
                // Skiping number of Rows count  
                var start = Request.Form["start"].FirstOrDefault();
                // Paging Length 10,20  
                var length = Request.Form["length"].FirstOrDefault();
                // Sort Column Name  
                var sortColumn = Request.Form["columns[" + Request.Form["order[0][column]"].FirstOrDefault() + "][name]"].FirstOrDefault();
                // Sort Column Direction ( asc ,desc)  
                var sortColumnDirection = Request.Form["order[0][dir]"].FirstOrDefault();
                // Search Value from (Search box)  
                var searchValue = Request.Form["search[value]"].FirstOrDefault();

                //Paging Size (10,20,50,100)  
                int pageSize = length != null ? Convert.ToInt32(length) : 0;
                int skip = start != null ? Convert.ToInt32(start) : 0;
                int recordsTotal = 0;

                // Getting all Customer data  
                var contentData = (from tempcontent in _context.Contents
                                    select tempcontent);

                //Sorting  
                if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
                {
                    //customerData = customerData.OrderBy(sortColumn + " " + sortColumnDirection);
                }
                //Search  
                if (!string.IsNullOrEmpty(searchValue))
                {
                    contentData = contentData.Where(m => m.ContentDetails == searchValue);
                }

                //total number of rows count   
                recordsTotal = contentData.Count();
                //Paging   
                var data = contentData.Skip(skip).Take(pageSize).ToList();
                //Returning Json Data  
                return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data });

            }
            catch (Exception)
            {
                throw;
            }
        }

        public IActionResult HomeBanner()
        {
            //var banner = _context.Contents.SingleOrDefault(x => x.ContentType == "HOME_MAIN_BANNER" && x.IsActive == true);
            //return View(banner);
            return View();
        }

        public ActionResult EditContent(int contentId)
        {
            var content = _context.Contents.SingleOrDefault(x => x.ContentId == contentId && x.IsActive == true);
            return PartialView("_EditContent", content);
        }

    }
}

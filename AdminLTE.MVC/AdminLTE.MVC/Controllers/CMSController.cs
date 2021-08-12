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
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult HomeBanner()
        {           
            var banner = _context.Contents.SingleOrDefault(x => x.ContentType == "HOME_MAIN_BANNER" && x.IsActive == true);
            return View(banner);
        }
    }
}

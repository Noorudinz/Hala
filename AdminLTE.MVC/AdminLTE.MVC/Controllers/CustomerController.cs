using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.MVC.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult ShowList()
        {
            return View();
        }
    }
}

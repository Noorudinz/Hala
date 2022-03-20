using AdminLTE.MVC.Data;
using AdminLTE.MVC.Models;
using AdminLTE.MVC.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly IBrand _brandRepo;
        public ProductController(IBrand context)
        {
            _brandRepo = context;
        }
            

        public IActionResult Index()
        {
            var Order = OrdersDetails.GetAllRecords();
            ViewBag.DataSource = Order;
            return View();
        }


    }
}

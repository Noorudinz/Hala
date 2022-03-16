﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AdminLTE.MVC.Models;
using Microsoft.AspNetCore.Authorization;
using AdminLTE.MVC.Data;
using Microsoft.Extensions.Caching.Memory;


namespace AdminLTE.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private ApplicationDbContext _context;
        private IMemoryCache _memoryCache;
        public HomeController(ILogger<HomeController> logger, ApplicationDbContext context, IMemoryCache memoryCache)
        {
            _logger = logger;
            _context = context;
            _memoryCache = memoryCache;

        }

        [AllowAnonymous]
        public IActionResult Index()
        {
            ViewBag.TotalUserRegister = _context.CustomerMaster.Count();
            return View();
            
        }
      
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Customer()
        {
            return View();
        }

        //[OutputCache(Duration = 120)]
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
                var customerData = (from tempcustomer in _context.CustomerMaster
                                    select tempcustomer);

                //Sorting  
                if (!(string.IsNullOrEmpty(sortColumn) && string.IsNullOrEmpty(sortColumnDirection)))
                {
                    //customerData = customerData.OrderBy(sortColumn + " " + sortColumnDirection);
                }
                //Search  
                if (!string.IsNullOrEmpty(searchValue))
                {
                    customerData = customerData.Where(m => m.CustomerName == searchValue);
                }

                //total number of rows count   
                recordsTotal = customerData.Count();
                //Paging   
                var data = customerData.Skip(skip).Take(pageSize).ToList();
                //Returning Json Data  
                return Json(new { draw = draw, recordsFiltered = recordsTotal, recordsTotal = recordsTotal, data = data });

            }
            catch (Exception)
            {
                throw;
            }

        }

      
        [HttpPost]
        public ActionResult CreateCustomer(CustomerMaster model)
        {
            try
            {
                model.UserType = "Web";
                model.IsActive = true;
                model.CreatedDate = DateTime.Now;
                model.UpdatedDate = null;
                _context.CustomerMaster.Add(model);
                _context.SaveChanges();
                LoadData();

                return View();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public ActionResult EditCustomer(int customerId)
        {       
           var cust = _context.CustomerMaster.SingleOrDefault(x => x.CustomerId == customerId && x.IsActive == true);           
           return PartialView("_EditCustomer", cust);
        }

        public enum UserType
        {
            Web = 1,
            Google = 2,
            FaceBook = 3,
            Twitter = 4
        }

        [HttpPost]
        public ActionResult UpdateCustomer(CustomerMaster model)
        {
            try
            {    
                
                if (model != null)
                {
                    var customer = _context.CustomerMaster.SingleOrDefault(x => x.CustomerId == model.CustomerId && x.IsActive == true);
                    customer.CustomerName = model.CustomerName;
                    customer.Email = model.Email;
                    customer.Phone = model.Phone;
                    customer.UpdatedDate = DateTime.Now;
                    _context.Update(customer);
                    _context.SaveChanges();
                    //LoadData();
                }

                return View();

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        public ActionResult DeleteCustomer(int ID)
        {
            var cust = _context.CustomerMaster.SingleOrDefault(x => x.CustomerId == ID && x.IsActive == true);

            if (cust != null)
            {
                cust.IsActive = false;
                cust.UpdatedDate = DateTime.Now;
                _context.Update(cust);
                _context.SaveChanges();
                //LoadData();
            }

            return View();
        }

    }
}

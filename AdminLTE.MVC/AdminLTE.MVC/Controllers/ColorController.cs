using AdminLTE.MVC.Models;
using AdminLTE.MVC.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.MVC.Controllers
{
    public class ColorController : Controller
    {
        private readonly IColor _colorRepo;
        public ColorController(IColor context)
        {
            _colorRepo = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public List<Color> GetAllColors()
        {
            var colorList = _colorRepo.GetAllColors()
                .Select(s => new Color { ColorId = s.ColorId, Color_Name = s.Color_Name })
                .ToList();
            return colorList;
        }
    }
}

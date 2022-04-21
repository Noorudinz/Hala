using AdminLTE.MVC.Data;
using AdminLTE.MVC.Models;
using AdminLTE.MVC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.MVC.Implementation
{
    public class ColorRepository: IColor
    {
        private readonly ApplicationDbContext _context;

        public ColorRepository(ApplicationDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public Color AddColor(Color color)
        {
            throw new NotImplementedException();
        }

        public void DeleteColor(int colorId)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetAllColors()
        {
            return _context.Color.ToList();
        }

        public Color GetColorById(int colorId)
        {
            throw new NotImplementedException();
        }

        public int[] GetColorByProductId(int productId)
        {
            return _context.ProductsColor.Where(e => e.ProductId == productId)
                .Select(a => a.ColorId).ToArray();
        }

        public Color UpdateColor(Color color)
        {
            throw new NotImplementedException();
        }
    }
}

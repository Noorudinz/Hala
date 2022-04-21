using AdminLTE.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.MVC.Repository
{
    public interface IColor
    {
        List<Color> GetAllColors();
        Color GetColorById(int colorId);
        int[] GetColorByProductId(int productId);
        Color AddColor(Color color);
        Color UpdateColor(Color color);
        void DeleteColor(int colorId);
    }
}

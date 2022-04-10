using AdminLTE.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.MVC.Repository
{
    public interface IImages
    {
        List<Images> GetAllImages();
        Images GetImagesById(int imagesId);
        AddProductNameResponse AddImages(ProductImages productImages);
        Images UpdateImages(Images images);
        void DeleteImages(int imagesId);
    }
}

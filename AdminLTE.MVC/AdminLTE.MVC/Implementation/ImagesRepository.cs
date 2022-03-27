using AdminLTE.MVC.Data;
using AdminLTE.MVC.Models;
using AdminLTE.MVC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.MVC.Implementation
{
    public class ImagesRepository: IImages
    {
        private readonly ApplicationDbContext _context;
        public ImagesRepository(ApplicationDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public Images AddImages(Images images)
        {
            throw new NotImplementedException();
        }

        public void DeleteImages(int imagesId)
        {
            throw new NotImplementedException();
        }

        public List<Images> GetAllImages()
        {
            throw new NotImplementedException();
        }

        public Images GetImagesById(int imagesId)
        {
            throw new NotImplementedException();
        }

        public Images UpdateImages(Images images)
        {
            throw new NotImplementedException();
        }
    }
}

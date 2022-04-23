using AdminLTE.MVC.Data;
using AdminLTE.MVC.Models;
using AdminLTE.MVC.Repository;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.MVC.Implementation
{
    public class ImagesRepository: IImages
    {
        private readonly ApplicationDbContext _context;
        [Obsolete]
        private readonly IHostingEnvironment _hostingEnvironment;

        [Obsolete]
        public ImagesRepository(ApplicationDbContext appDbContext,
                               IHostingEnvironment hostingEnvironment)
        {
            _context = appDbContext;
            this._hostingEnvironment = hostingEnvironment;
        }

        [Obsolete]
        public AddProductNameResponse AddImages(BrowseImage productImages, ProductMaster productMaster)
        {
            string Main_URL = null, URL1 = null, URL2 = null, URL3 = null;
            if(productImages != null)
            {
                string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "ProductImages");

                Main_URL = Guid.NewGuid().ToString() + "_" + productImages.Main_URL.FileName;
                string filePath_Main_URL = Path.Combine(uploadsFolder, Main_URL);
                productImages.Main_URL.CopyTo(new FileStream(filePath_Main_URL, FileMode.Create));

                URL1 = Guid.NewGuid().ToString() + "_" + productImages.URL_1.FileName;
                string filePath_URL1 = Path.Combine(uploadsFolder, URL1);
                productImages.URL_1.CopyTo(new FileStream(filePath_URL1, FileMode.Create));

                URL2 = Guid.NewGuid().ToString() + "_" + productImages.URL_2.FileName;
                string filePath_URL2 = Path.Combine(uploadsFolder, URL2);
                productImages.URL_2.CopyTo(new FileStream(filePath_URL2, FileMode.Create));

                URL3 = Guid.NewGuid().ToString() + "_" + productImages.URL_3.FileName;
                string filePath_URL3 = Path.Combine(uploadsFolder, URL3);
                productImages.URL_3.CopyTo(new FileStream(filePath_URL3, FileMode.Create));
            }
          
            if(productMaster.Product_Id != 0)
            {
                var images = new Images();
                images.Product_Id = productMaster.Product_Id;
                images.Main_URL = Main_URL;
                images.URL_1 = URL1;
                images.URL_2 = URL2;
                images.URL_3 = URL3;
                images.IsActive = true;
                images.CreatedOn = DateTime.Now;

                _context.Images.Add(images);
                _context.SaveChanges();

                int imageId = images.ImagesId;

                var updateProductImages = _context.Product
                       .FirstOrDefault(e => e.Product_Id == productMaster.Product_Id);

                if(updateProductImages != null)
                {
                    updateProductImages.Product_Id = productMaster.Product_Id;
                    updateProductImages.ImagesId = imageId;
                    updateProductImages.UpdatedOn = DateTime.Now;

                    _context.SaveChanges();

                    return (new AddProductNameResponse()
                    {
                        ProductId = productMaster.Product_Id,
                        Status = "Success",
                        Message = "Images Added Successfully !",
                    });
                }
            }

            return (new AddProductNameResponse()
            {
                ProductId = 0,
                Status = "Failure",
                Message = "Product Image Uploading Failed !",
            });

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

        public Images GetImagesByProductId(int productId)
        {
            return _context.Images.Where(a => a.Product_Id == productId).FirstOrDefault();
        }

        public Images UpdateImages(Images images)
        {
            throw new NotImplementedException();
        }

        public AddProductNameResponse UpdateImages(EditBrowseImage productImages, ProductMaster product)
        {
            var images = _context.Images.Where(a => a.Product_Id == product.Product_Id).FirstOrDefault();

            string uploadsFolder = Path.Combine(_hostingEnvironment.WebRootPath, "ProductImages");

            string Main_URL = images.Main_URL, URL1 = images.URL_1, URL2 = images.URL_2, URL3 = images.URL_3;

            if (productImages.Main_URL_File != null)
            {
                if(System.IO.File.Exists(Path.Combine(uploadsFolder, images.Main_URL)))
                {
                    System.IO.File.Delete(Path.Combine(uploadsFolder, images.Main_URL));
                }               

                Main_URL = Guid.NewGuid().ToString() + "_" + productImages.Main_URL_File.FileName;
                string filePath_Main_URL = Path.Combine(uploadsFolder, Main_URL);
                productImages.Main_URL_File.CopyTo(new FileStream(filePath_Main_URL, FileMode.Create));
            }

            if (productImages.URL_1_File != null)
            {
                if (System.IO.File.Exists(Path.Combine(uploadsFolder, images.URL_1)))
                {
                    System.IO.File.Delete(Path.Combine(uploadsFolder, images.URL_1));
                }

                URL1 = Guid.NewGuid().ToString() + "_" + productImages.URL_1_File.FileName;
                string filePath_URL1 = Path.Combine(uploadsFolder, URL1);
                productImages.URL_1_File.CopyTo(new FileStream(filePath_URL1, FileMode.Create));
            }

            if (productImages.URL_2_File != null)
            {
                if (System.IO.File.Exists(Path.Combine(uploadsFolder, images.URL_2)))
                {
                    System.IO.File.Delete(Path.Combine(uploadsFolder, images.URL_2));
                }

                URL2 = Guid.NewGuid().ToString() + "_" + productImages.URL_2_File.FileName;
                string filePath_URL2 = Path.Combine(uploadsFolder, URL2);
                productImages.URL_2_File.CopyTo(new FileStream(filePath_URL2, FileMode.Create));
            }

            if (productImages.URL_3_File != null)
            {
                if (System.IO.File.Exists(Path.Combine(uploadsFolder, images.URL_3)))
                {
                    System.IO.File.Delete(Path.Combine(uploadsFolder, images.URL_3));
                }

                URL3 = Guid.NewGuid().ToString() + "_" + productImages.URL_3_File.FileName;
                string filePath_URL3 = Path.Combine(uploadsFolder, URL3);
                productImages.URL_3_File.CopyTo(new FileStream(filePath_URL3, FileMode.Create));
            }


            if (product.Product_Id > 0)
            {               
                images.Product_Id = product.Product_Id;
                images.Main_URL = Main_URL;
                images.URL_1 = URL1;
                images.URL_2 = URL2;
                images.URL_3 = URL3;
                images.IsActive = true;
                images.UpdatedOn = DateTime.Now;

                _context.SaveChanges();

                var updateProductImages = _context.Product
                       .FirstOrDefault(e => e.Product_Id == product.Product_Id);

                if (updateProductImages != null)
                {
                    updateProductImages.Product_Id = product.Product_Id;
                    updateProductImages.ImagesId = images.ImagesId;
                    updateProductImages.UpdatedOn = DateTime.Now;

                    _context.SaveChanges();

                    return (new AddProductNameResponse()
                    {
                        ProductId = product.Product_Id,
                        Status = "Success",
                        Message = "Images Updated Successfully !",
                    });
                }
            }

            return (new AddProductNameResponse()
            {
                ProductId = 0,
                Status = "Failure",
                Message = "Product Image Uploading Failed !",
            });
        }
    }
}

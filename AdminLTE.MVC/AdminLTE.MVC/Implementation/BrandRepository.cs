using AdminLTE.MVC.Data;
using AdminLTE.MVC.Models;
using AdminLTE.MVC.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.MVC.Implementation
{
    public class BrandRepository : IBrand
    {
        private readonly ApplicationDbContext _context;

        public BrandRepository(ApplicationDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public Brand AddOrEditCategory(Brand brand)
        {
            var brandMaster = new Brand();
            if (brand.BrandId > 0)
            {
                brandMaster = _context.Brand.Where(a => a.BrandId == brand.BrandId).FirstOrDefault();
                brandMaster.BrandName = brand.BrandName;
                brandMaster.IsActive = true;
                brandMaster.UpdatedOn = DateTime.Now;
                _context.SaveChanges();

                return brandMaster;
            }

            brandMaster.BrandName = brand.BrandName;
            brandMaster.IsActive = true;
            brandMaster.CreatedOn = DateTime.Now;

            _context.Brand.Add(brandMaster);
            _context.SaveChanges();

            return brandMaster;
        }

        public BrandResponse DeleteBrand(int brandId)
        {
            var brand = _context.Brand.Where(a => a.BrandId == brandId).FirstOrDefault();
            if (brand != null && brand.BrandId > 0)
            {
                brand.IsActive = false;
                brand.UpdatedOn = DateTime.Now;
                _context.SaveChanges();

                return new BrandResponse
                {
                    IsUpdated = true,
                    Message = "Deleted Brand Succesfully"
                };
            }

            return new BrandResponse
            {
                IsUpdated = false,
                Message = "Deleted Brand Failed"
            };
        }

        public IEnumerable<Brand> GetAllBrands()
        {
            return _context.Brand.Where(a => a.IsActive == true).ToList();
        }

        public Brand GetBrandById(int brandId)
        {
            return _context.Brand.Where(w => w.BrandId == brandId).FirstOrDefault();
        }

        public Brand UpdateBrand(Brand brand)
        {
            throw new NotImplementedException();
        }

    }
}

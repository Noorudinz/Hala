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

        public Brand AddBrand(Brand brand)
        {
            throw new NotImplementedException();
        }

        public void DeleteBrand(int brandId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Brand> GetAllBrands()
        {
            return _context.Brand.Where(a => a.IsActive == true).ToList();
        }

        public Brand GetBrandById(int brandId)
        {
            throw new NotImplementedException();
        }

        public Brand UpdateBrand(Brand brand)
        {
            throw new NotImplementedException();
        }
    }
}

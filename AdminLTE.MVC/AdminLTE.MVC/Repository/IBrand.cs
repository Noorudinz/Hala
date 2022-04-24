﻿using AdminLTE.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdminLTE.MVC.Repository
{
    public interface IBrand
    {
        IEnumerable<Brand> GetAllBrands();
        Brand GetBrandById(int brandId);
        Brand AddOrEditCategory(Brand brand);
        Brand UpdateBrand(Brand brand);
        BrandResponse DeleteBrand(int brandId);
    }
}

﻿using HALA.DL.BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HALA.DL.BL.Repositories
{
    public interface IProduct
    {
        ProductDetailsResult FetchProductInformation(int productId);
    }
}
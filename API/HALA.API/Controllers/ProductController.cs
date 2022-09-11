using HALA.API.Framework;
using HALA.DL.BL.Repositories;
using HALA.DTO.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RR = HALA.DTO.RequestResponseWrappers;
using BLO = HALA.DL.BO;

namespace HALA.API.Controllers
{
    public class ProductController : ApiController
    {
        public readonly IProduct _productepository;
        private readonly AutoMapper.IMapper _mapper;

        public ProductController(IProduct repository)
        {
            _productepository = repository;
            HALAAutoMapper automap = new HALAAutoMapper();
            _mapper = automap.GetProductAutoMapper();
        }

        [HttpGet]
        [Route(ProductURI.GetProductDetailsByProductId)]
        public RR.ProductDetails GetProductDetailsByProductId(int productId)
        {
            try
            {
                BLO.ProductDetailsResult result = _productepository.FetchProductInformation(productId);
                return _mapper.Map<BLO.ProductDetailsResult, RR.ProductDetails>(result);
            }
            catch (Exception ex)
            {
                return new RR.ProductDetails
                {
                    IsTransactionDone = false,
                    TransactionErrorMessage = ex.Message
                };
            }
        }
    }
}

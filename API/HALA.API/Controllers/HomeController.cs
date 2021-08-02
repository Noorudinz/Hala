using HALA.API.Framework;
using HALA.API;
using HALA.DL.BL.Repositories;
using HALA.DTO.Constants;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Security.Claims;
using System.Web.Http;
using BLO = HALA.DL.BO;
using RR = HALA.DTO.RequestResponseWrappers;

namespace HALA.API.Controllers
{
    public class HomeController : ApiController
    {
        public readonly IContent _contentRepository;
        private readonly AutoMapper.IMapper _mapper;

        public HomeController(IContent repository)
        {
            _contentRepository = repository;
            HALAAutoMapper automap = new HALAAutoMapper();
            _mapper = automap.GetContentAutoMapper();
        }

        //[HttpPost]
        //[Route(CustomerURI.PostCustomerMaster)]
        //public RR.CustomerMasterRes PostCustomerMasterDetails(RR.CustomerMasterReq userdetails)
        //{
        //    try
        //    {
        //        var identity = (ClaimsIdentity)User.Identity;
        //        IEnumerable<Claim> claims = identity.Claims;

        //        BLO.CustomerMasterReq userMaster = _mapper.Map<RR.CustomerMasterReq, BLO.CustomerMasterReq>(userdetails);
        //        BLO.CustomerMasterRes result = _customerRepository.InsertCustomerMasterDetails(userMaster);
        //        return _mapper.Map<BLO.CustomerMasterRes, RR.CustomerMasterRes>(result);
        //    }
        //    catch (Exception ex)
        //    {
        //        return new RR.CustomerMasterRes
        //        {
        //            IsTransactionDone = false,
        //            TransactionErrorMessage = ex.Message
        //        };
        //    }
        //}

        [HttpGet]
        [Route(ContentURI.FetchHomeMainBanner)]
        public RR.GetContentResponse GetCustomerByEmail(string type)
        {
            try
            {
                BLO.GetContentResponse result = _contentRepository.FetchHomeMainBanner(type);
                return _mapper.Map<BLO.GetContentResponse, RR.GetContentResponse>(result);
            }
            catch (Exception ex)
            {
                return new RR.GetContentResponse
                {
                    IsTransactionDone = false,
                    TransactionErrorMessage = ex.Message
                };
            }
        }
    }
}

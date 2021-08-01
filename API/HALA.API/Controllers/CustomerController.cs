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
    public class CustomerController : ApiController
    {
        public readonly ICustomer _customerRepository;
        private readonly AutoMapper.IMapper _mapper;

        public CustomerController(ICustomer repository)
        {
            _customerRepository = repository;
            HALAAutoMapper automap = new HALAAutoMapper();
            _mapper = automap.GetCustomerAutoMapper();
        }

        [HttpPost]
        [Route(CustomerURI.PostCustomerMaster)]
        public RR.CustomerMasterRes PostCustomerMasterDetails(RR.CustomerMasterReq userdetails)
        {
            try
            {
                var identity = (ClaimsIdentity)User.Identity;
                IEnumerable<Claim> claims = identity.Claims;

                BLO.CustomerMasterReq userMaster = _mapper.Map<RR.CustomerMasterReq, BLO.CustomerMasterReq>(userdetails);
                BLO.CustomerMasterRes result = _customerRepository.InsertCustomerMasterDetails(userMaster);
                return _mapper.Map<BLO.CustomerMasterRes, RR.CustomerMasterRes>(result);
            }
            catch (Exception ex)
            {
                return new RR.CustomerMasterRes
                {
                    IsTransactionDone = false,
                    TransactionErrorMessage = ex.Message
                };
            }
        }

        [HttpGet]
        [Route(CustomerURI.GetCustomerByEmail)]
        public RR.CustomerDetailsResult GetCustomerByEmail(string emailId)
        {
            try
            {
                BLO.CustomerDetailsResult result = _customerRepository.FetchUserInformation(emailId);
                return _mapper.Map<BLO.CustomerDetailsResult, RR.CustomerDetailsResult>(result);
            }
            catch (Exception ex)
            {
                return new RR.CustomerDetailsResult
                {
                    IsTransactionDone = false,
                    TransactionErrorMessage = ex.Message
                };
            }
        }
    }
}

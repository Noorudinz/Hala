using HALA.DTO.RequestResponseWrappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BLO = HALA.DL.BO;

using RR = HALA.DTO.RequestResponseWrappers;

namespace HALA.API.Framework
{
    public class HALAAutoMapper
    {
        private AutoMapper.MapperConfiguration _mapperConfig;
        private AutoMapper.IMapper _mapper;

        public AutoMapper.IMapper GetCustomerAutoMapper()
        {
            _mapperConfig = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.CreateMap<BLO.CustomerMasterReq,
                            RR.CustomerMasterReq>().ReverseMap();
                cfg.CreateMap<BLO.CustomerMasterRes,
                          RR.CustomerMasterRes>().ReverseMap();

                cfg.CreateMap<BLO.CustomerDetailsResult,
                        RR.CustomerDetailsResult>().ReverseMap();

                //cfg.CreateMap<BLO.AdminRegister,
                //            RR.AdminRegister>().ReverseMap();
                //cfg.CreateMap<BLO.PostAdminUserResult,
                //          RR.PostAdminUserResult>().ReverseMap();


            });
            return (_mapper = _mapperConfig.CreateMapper());
        }

        public AutoMapper.IMapper GetAdminAutoMapper()
        {
            _mapperConfig = new AutoMapper.MapperConfiguration(cfg =>
            {
              //  cfg.CreateMap<BLO.InsuranceProductMasterResponse,
              //              RR.InsuranceProductMasterResponse>().ReverseMap();

              //  cfg.CreateMap<BLO.InsuranceProductMaster,
              //              RR.InsuranceProductMaster>().ReverseMap();
           
              //  cfg.CreateMap<BLO.BranchMaster,
              //              RR.BranchMaster>().ReverseMap();

              //  cfg.CreateMap<BLO.BranchMasterResponse,
              //              RR.BranchMasterResponse>().ReverseMap();

              //  cfg.CreateMap<BLO.MotorCoverMaster,
              //              RR.MotorCoverMaster>().ReverseMap();

              //  cfg.CreateMap<BLO.MotorCoverMasterResponse,
              //              RR.MotorCoverMasterResponse>().ReverseMap();

              //  cfg.CreateMap<BLO.MotorProductCover,
              //              RR.MotorProductCover>().ReverseMap();

              //  cfg.CreateMap<BLO.MotorProductCoverResponse,
              //              RR.MotorProductCoverResponse>().ReverseMap();

              //  cfg.CreateMap<BLO.AgentMaster,
              //             RR.AgentMaster>().ReverseMap();

              //  cfg.CreateMap<BLO.AgentMasterResponse,
              //              RR.AgentMasterResponse>().ReverseMap();

              //  cfg.CreateMap<BLO.UserMasterDetails,
              //             RR.UserMasterDetails>().ReverseMap();

              //  cfg.CreateMap<BLO.UserMasterDetailsResponse,
              //              RR.UserMasterDetailsResponse>().ReverseMap();

              //  cfg.CreateMap<BLO.CategoryMaster,
              //            RR.CategoryMaster>().ReverseMap();

              //  cfg.CreateMap<BLO.CategoryMasterResponse,
              //              RR.CategoryMasterResponse>().ReverseMap();

              //  cfg.CreateMap<BLO.InsuredMasterDetails,
              //            RR.InsuredMasterDetails>().ReverseMap();

              //  cfg.CreateMap<BLO.InsuredMasterDetailsResponse,
              //              RR.InsuredMasterDetailsResponse>().ReverseMap();

              //  cfg.CreateMap<BLO.InsuredResponse,
              //             RR.InsuredResponse>().ReverseMap();

              //  cfg.CreateMap<BLO.InsuredRequest,
              //             RR.InsuredRequest>().ReverseMap();
              //  cfg.CreateMap<BLO.AgencyInsuredRequest,
              //             RR.AgencyInsuredRequest>().ReverseMap();

              //  cfg.CreateMap<BLO.AgencyInsuredResponse,
              //              RR.AgencyInsuredResponse>().ReverseMap();

              //  cfg.CreateMap<BLO.DocumentDetailsResponse,
              //      RR.DocumentDetailsResult>().ReverseMap();

              //  cfg.CreateMap<BLO.DocumentDetailsRequest,
              //      RR.DocumentDetailsRequest>().ReverseMap();

              //  cfg.CreateMap<BLO.AgencyUserRequest,
              //      RR.AgencyUserRequest>().ReverseMap();

              //  cfg.CreateMap<BLO.AgencyUserResponse,
              //     RR.AgencyUserResponse>().ReverseMap();

              //  cfg.CreateMap<BLO.AgecyProductRequest,
              //     RR.AgecyProductRequest>().ReverseMap();

              //  cfg.CreateMap<BLO.MotorProduct,
              //    RR.MotorProduct>().ReverseMap();

              //  cfg.CreateMap<BLO.HomeProduct,
              //   RR.HomeProduct>().ReverseMap();

              //  cfg.CreateMap<BLO.AgencyProduct,
              //  RR.AgencyProduct>().ReverseMap();

              //  cfg.CreateMap<BLO.AgencyProductResponse,
              //  RR.AgencyProductResponse>().ReverseMap();

              //  cfg.CreateMap<BLO.MotorCoverRequest,
              //  RR.MotorCoverRequest>().ReverseMap();

              //  cfg.CreateMap<BLO.MotorCoverResponse,
              //  RR.MotorCoverResponse>().ReverseMap();

              //  cfg.CreateMap<BLO.MotorCovers,
              //  RR.MotorCovers>().ReverseMap();

              //  cfg.CreateMap<BLO.MotorVehicleMaster,
              // RR.MotorVehicleMaster>().ReverseMap();

              //  cfg.CreateMap<BLO.MotorVehicleMasterResponse,
              // RR.MotorVehicleMasterResponse>().ReverseMap();

              //  cfg.CreateMap<BLO.MotorProductMasterResponse,
              //RR.MotorProductMasterResponse>().ReverseMap();

              //  cfg.CreateMap<BLO.MotorProductMaster,
              // RR.MotorProductMaster>().ReverseMap();


              //  cfg.CreateMap<BLO.MotorProductMaster,
              //  RR.MotorProductMaster>().ReverseMap();


              //  cfg.CreateMap<BLO.MotorEngineCCMaster,
              //  RR.MotorEngineCCMaster>().ReverseMap();

              //  cfg.CreateMap<BLO.MotorEngineCCResponse,
              //RR.MotorEngineCCResponse>().ReverseMap();

              //  cfg.CreateMap<BLO.MotorYearMaster,
              // RR.MotorYearMaster>().ReverseMap();

              //  cfg.CreateMap<BLO.MotorYearMasterResponse,
              //  RR.MotorYearMasterResponse>().ReverseMap();

              //  cfg.CreateMap<BLO.MotorClaim,
              //  RR.MotorClaim>().ReverseMap();

              //  cfg.CreateMap<BLO.MotorEndorsementMaster, RR.MotorEndorsementMaster>().ReverseMap();

              //  cfg.CreateMap<BLO.HomeEndorsementMaster, RR.HomeEndorsementMaster>().ReverseMap();

              //  cfg.CreateMap<BLO.CategoryMaster, RR.CategoryMaster>().ReverseMap();

              //  cfg.CreateMap<BLO.RenewalPrecheckRequest, RR.RenewalPrecheckRequest>().ReverseMap();

              //  cfg.CreateMap<BLO.RenewalPrecheckResponse, RR.RenewalPrecheckResponse>().ReverseMap();

            });

            return (_mapper = _mapperConfig.CreateMapper());
        }

        public AutoMapper.IMapper GetContentAutoMapper()
        {
            _mapperConfig = new AutoMapper.MapperConfiguration(cfg =>
            {
                cfg.CreateMap<BLO.GetContentRequest,
                            RR.GetContentRequest>().ReverseMap();
                cfg.CreateMap<BLO.GetContentResponse,
                          RR.GetContentResponse>().ReverseMap();

            });
            return (_mapper = _mapperConfig.CreateMapper());
        }
    }
}
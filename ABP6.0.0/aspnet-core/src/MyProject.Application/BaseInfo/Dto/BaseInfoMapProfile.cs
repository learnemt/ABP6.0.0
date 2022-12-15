using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BaseInfo.Dto
{
    public class BaseInfoMapProfile : Profile
    {
        //Dto与实体映射
        public BaseInfoMapProfile(){
            CreateMap<CardFeeInfoDto, CardFeeInfo>();
            CreateMap<CommissionRulesDto, CommissionRules>();
            CreateMap<FitnessProjectInfosDto, FitnessProjectInfos>();
            CreateMap<CreateCardFeeInfoDto, CardFeeInfo>();
        }
    }
}

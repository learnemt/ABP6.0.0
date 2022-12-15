using Abp.Application.Services;
using Abp.Application.Services.Dto;
using MyProject.BaseInfo.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BaseInfo
{
        /// <summary>
        /// 应用接口服务
        /// </summary>
    public interface ICardFeeInfoAppService : IAsyncCrudAppService<CardFeeInfoDto, Guid>
    {
        //生命应用层需要的服务
        Task<CardFeeInfoDto> CreateCardFeeInfoAsync(CreateCardFeeInfoDto input);
        Task<ListResultDto<CardFeeInfoDto>> GetCardFeeInfos();
    }
}

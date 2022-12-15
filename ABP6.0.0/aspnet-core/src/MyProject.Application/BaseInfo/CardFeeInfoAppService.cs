using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using Abp.UI;
using MyProject.BaseInfo.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BaseInfo
{
    public class CardFeeInfoAppService : AsyncCrudAppService<CardFeeInfo, CardFeeInfoDto, Guid>,ICardFeeInfoAppService
    {
        private readonly BaseInfoManager _baseInfoManager;
        public CardFeeInfoAppService(IRepository<CardFeeInfo, Guid> repository, BaseInfoManager baseInfoManager) : base(repository)
        {
            _baseInfoManager = baseInfoManager;
        }
        /// <summary>
        /// 卡费信息
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public async Task<CardFeeInfoDto> CreateCardFeeInfoAsync(CreateCardFeeInfoDto input)
        {
            var cardFeeInfo = new CardFeeInfo();
            if (input.CardFee <= 0)
                throw new UserFriendlyException("金额输入有误");
            ObjectMapper.Map(input, cardFeeInfo);//映射
            await _baseInfoManager.CreateAsync(cardFeeInfo);//创建
            return MapToEntityDto(cardFeeInfo);
        }

        public async Task<ListResultDto<CardFeeInfoDto>> GetCardFeeInfos()
        {
            var cardFeeInfos = await Repository.GetAllListAsync(p => p.IsDeleted == false);
            return new ListResultDto<CardFeeInfoDto>(ObjectMapper.Map<List<CardFeeInfoDto>>(cardFeeInfos)); 
        }
    }
}
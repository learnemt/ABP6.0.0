using Abp.Domain.Repositories;
using Abp.Domain.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BaseInfo
{
    public class BaseInfoManager:DomainService//域服务
    {
        protected IRepository<CardFeeInfo, Guid> _cardFeeInfoRepository { get; set; }//声明仓储对象
        public BaseInfoManager(IRepository<CardFeeInfo, Guid> cardFeeInfoRepository) //构造函数
        {
            _cardFeeInfoRepository = cardFeeInfoRepository;//仓储对象注入方法体
        }

        public Task CreateAsync(CardFeeInfo cardFeeInfo)
        {
            throw new NotImplementedException(); 
        }
    }
}

using MyProject.BaseInfo.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyProject.Web.Models.BaseInfo
{
    public class CardFeeInfoViewModel
    {
        public IReadOnlyList<CardFeeInfoDto> cardFeeInfoDtos { get; set; }
        public int Count { get; set; }
    }
}

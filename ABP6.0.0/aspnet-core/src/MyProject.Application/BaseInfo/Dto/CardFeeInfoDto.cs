using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BaseInfo.Dto
{
    [AutoMapFrom(typeof(CardFeeInfo))]
    public class CardFeeInfoDto:EntityDto<Guid>
    {
        [StringLength(CardFeeInfo.MaxTypeNameLength)]
        [Required]
        public virtual String CardType { get; set; }
        [Required]
        public virtual int CardFee { get; set; }
    }
}

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
    [AutoMapFrom(typeof(CommissionRules))]
    public class CommissionRulesDto:EntityDto<Guid>
    {
        [Required]
        [StringLength(CommissionRules.MaxTypeNameLength)]
        public virtual String FeeType { get; set; }
        [StringLength(CommissionRules.MaxTypeNameLength)]
        [Required]
        public virtual String FeeName { get; set; }
        [Required]
        public virtual int Fee { get; set; }
        [Required]
        public virtual float CommissionFee { get; set; }
    }
}

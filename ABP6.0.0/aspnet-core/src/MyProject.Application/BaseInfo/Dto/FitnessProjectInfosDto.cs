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
    [AutoMapFrom(typeof(FitnessProjectInfos))]
    public class FitnessProjectInfosDto:EntityDto<Guid>
    {
        [Required]
        [StringLength(FitnessProjectInfos.MaxTypeNameLength)]
        public virtual String FitnessName { get; set; }
        [Required]
        public virtual int FitnessFee { get; set; }
        [Required]
        [StringLength(FitnessProjectInfos.MaxTypeNameLength+10)]
        public virtual String Introduction { get; set; }
    }
}

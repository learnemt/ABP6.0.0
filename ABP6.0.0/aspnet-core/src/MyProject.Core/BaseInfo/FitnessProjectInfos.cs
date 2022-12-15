using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject.BaseInfo
{
    [Table("saleFitnessProjectInfos")]
    public class FitnessProjectInfos : FullAuditedAggregateRoot<Guid>
    {
        public const int MaxTypeNameLength = 10;
        [Required]
        [StringLength(MaxTypeNameLength)]
        public virtual String FitnessName { get; set; }
        [Required]
        public virtual int FitnessFee { get; set; }
        /// <summary>
        /// 信息介绍
        /// </summary>
        [Required]
        [StringLength(MaxTypeNameLength+10)]
        public virtual String Introduction { get; set; }
    }
}

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
    [Table("SaleCommissionRules")]
    public class CommissionRules:FullAuditedAggregateRoot<Guid>
    {
        public const int MaxTypeNameLength = 10;
        [Required]
        [StringLength(MaxTypeNameLength)]
        public virtual string FeeType { get; set; }
        [StringLength(MaxTypeNameLength)]
        [Required]
        public virtual string FeeName { get; set; }
        [Required]
        public virtual int Fee { get; set; }
        [Required]
        public virtual float CommissionFee { get; set; }
    }
}

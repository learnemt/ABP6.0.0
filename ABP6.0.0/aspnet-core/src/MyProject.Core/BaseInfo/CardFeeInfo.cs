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
    /// <summary>
    /// 健身卡费用信息
    /// </summary>
    [Table("saleCardFeelInfo")] //特性，会生成数据对应名称
    public class CardFeeInfo : FullAuditedAggregateRoot<Guid>//不在指定主键
    {
        /// <summary>
        /// Maximum length of the <see cref="CardType"/> property
        /// </summary>
        public const int MaxTypeNameLength = 5;
        [Required]
        [StringLength(MaxTypeNameLength)]
        /// <summary>
        /// 健身卡类型
        /// </summary>
        public virtual string CardType { get; set; }
        /// <summary>
        /// 卡费
        /// </summary>
        [Required]
        public virtual int CardFee { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.logic.Agreement
{
    /// <summary>
    /// 首次交易约束
    /// </summary>
   public class FirstTransactionConstraint
    {
        public Guid AgreementId { get; set; }

        /// <summary>
        /// 首提数量
        /// </summary>
        public int? FirstQty { get; set; }

        /// <summary>
        /// 首提金额
        /// </summary>
        public decimal? FirstAmount { get; set; }

        /// <summary>
        /// 首提协议汇款时间
        /// </summary>
        public DateTime? FirstRemittanceTime { get; set; }
        /// <summary>
        /// 备注
        /// </summary>
        public string FirstRemark { get; set; }
    }
}

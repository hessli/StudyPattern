using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.logic.Agreement
{
    /// <summary>
    /// 保证金约束信息
    /// </summary>
   public class CashConstraint
    {
        /// <summary>
        /// 协议Id
        /// </summary>
        public Guid AgreementId { get; set; }
        /// <summary>
        /// 保证金
        /// </summary>
        public decimal? CashDeposit { get; set; }
        /// <summary>
        /// 保证金性质
        /// </summary>
        public int? DepositNature { get; set; }
        /// <summary>
        /// 汇款时间
        /// </summary>
        public DateTime? RemittanceTime { get; set; }
        /// <summary>
        /// 开发保证金
        /// </summary>
        public decimal? ExploitationDeposit { get; set; }
        /// <summary>
        /// 销售保证金
        /// </summary>
        public decimal? SaleDeposit { get; set; }
        /// <summary>
        /// 市场保证金
        /// </summary>
        public decimal? MarketDeposit { get; set; }
        /// <summary>
        /// 保证金说明
        /// </summary>
        public string DepositRemark { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.logic.Agreement
{
    /// <summary>
    /// 任务约束
    /// </summary>
   public class MissionConstraint
    {
        public Guid AgreementId { get; set; }
        /// <summary>
        /// 月任务量
        /// </summary>
        public int? MissionMonthQty { get; set; }
        /// <summary>
        /// 年任务量
        /// </summary>
        public int? MissionYearQty { get; set; }
        /// <summary>
        /// 起算月份
        /// </summary>
        public DateTime? MissionStartTime { get; set; }

    }
}

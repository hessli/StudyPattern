using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.logic.Agreement
{
   public class CommissionAgreement: AgreementBase
    {
        /// <summary>
        /// 供应方坐庄账户
        /// </summary>
        public Guid SupplierBankerAccount { get; set; }

        /// <summary>
        /// 供应方配送公司
        /// </summary>
        public Guid SupplierDistributionCompany { get; set; }

        /// <summary>
        /// 采购方账户
        /// </summary>
        public Guid Account { get; set; }

        /// <summary>
        /// 业务负责人
        /// </summary>
        public Guid BusinessPrincipal { get; set; }
      

        public RebateModel RebateModel { get; set; }
        /// <summary>
        /// 客服负责人
        /// </summary>
        public Guid ServicePrincipal { get; set; }
        public Guid Investment { get; set; }

     

        private IOperateModel _operateModel;
        public override IOperateModel OperateModel
        {
            get
            {
                if(_operateModel==null)
                _operateModel = this.RebateModel;
                return _operateModel;
            }
        }
    }
}

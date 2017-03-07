using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.logic.Agreement
{
    public class CustomerAgreement : AgreementBase
    {

        public CustomerAgreement():base()
        {
            this.NotSellScope = new List<AgreementScope>();
        }
        /// <summary>
        /// 采购方账户
        /// </summary>
        public Guid Account { get; set; }
        /// <summary>
        /// 采购方公户公司
        /// </summary>
        public Guid StandardCompany { get; set; }
        /// <summary>
        ///采购方 配送公司
        /// </summary>
        public Guid DistributionCompany { get; set; }
        /// <summary>
        /// 供货方公户账户
        /// </summary>
        public Guid SupplierPublicAccount { get; set; }
        /// <summary>
        /// 供货方私户
        /// </summary>
        public Guid SupplierPrivateAccount { get; set; }
        /// <summary>
        /// 业务负责人
        /// </summary>
        public Guid BusinessPrincipal { get; set; }
        /// <summary>
        /// 客服负责人
        /// </summary>
        public Guid ServicePrincipal { get; set; }
        /// <summary>
        /// 底价模式
        /// </summary>
        public FloorMode FloorMode { get; set; }
        /// <summary>
        /// 销售信息Id
        /// </summary>
        public Guid Investment { get; set; }
        /// <summary>
        /// 保留范围
        /// </summary>
        public IList<AgreementScope> NotSellScope { get; set; }
        /// <summary>
        /// 任务约束
        /// </summary>
        public MissionConstraint MissionConstraint { get; set; }
        /// <summary>
        /// 保证金约束
        /// </summary>
        public CashConstraint CashConstraint { get; set; }
        /// <summary>
        /// 首提约束
        /// </summary>
        public FirstTransactionConstraint FirstTransactionConstraint { get; set; }
        /// <summary>
        /// 高开模式
        /// </summary>
        public CustomerInvoiceModel InvoiceModel { get; set; }

        private IOperateModel _oprateModel;
        public override IOperateModel OperateModel
        {
            get
            {
                if (_oprateModel == null)
                {
                    switch (OperationType)
                    {
                        case OperationType.高开:
                            _oprateModel = InvoiceModel;
                            break;

                        case OperationType.底价:
                            _oprateModel = FloorMode;
                            break;
                        default:
                            throw new Exception("客户协议不支持当前的操作模式");
                    }
                }
                return _oprateModel;
            }
        }

        public override void RquireValidate()
        {
            base.RquireValidate();
        }
    }
}

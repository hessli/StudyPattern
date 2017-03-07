using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.logic.Agreement
{
   public class SupplierAgreement: AgreementBase
    {

        public SupplierAgreement():base()
        {
            this.NotSellScope = new List<AgreementScope>();
        }
        /// <summary>
        /// 供应方账户
        /// </summary>
        public Guid SupplierAccount { get; set; }
        /// <summary>
        /// 供应方公户公司
        /// </summary>
        public Guid SupplierStandardCompany { get; set; }
        /// <summary>
        /// 采购方公户账户
        /// </summary>
        public Guid PublicAccount { get; set; }
        /// <summary>
        /// 采购方私户
        /// </summary>
        public Guid PrivateAccount { get; set; }
        /// <summary>
        /// 采购负责人
        /// </summary>
        public Guid PurchasePrincipal { get; set; }
        /// <summary>
        /// 底价模式
        /// </summary>
        public FloorMode FloorMode { get; set; }
        /// <summary>
        /// 高开模式
        /// </summary>
        public SupplierInvoiceModel InvoiceModel { get; set; }
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
        public Guid ProductId { get; set; }
        /// <summary>
        /// 保留范围
        /// </summary>
        public IList<AgreementScope> NotSellScope { get; set; }

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
                            throw new Exception("供应商协议不支持当前的操作模式");
                    }
                }
                return _oprateModel;
            }
        }
    }
}

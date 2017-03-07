using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.logic.Agreement
{
    public abstract class AgreementBase
    {

        public AgreementBase()
        {
            this.ProxyScope = new List<AgreementScope>();
        }

        public int AgreementWay { get; set; }
        public string Serialno { get; set; }
        public int State { get; set; }
        private OperationType _oprationType;
        public OperationType OperationType
        {
            get
            {
                return _oprationType;
            }
        }
        private int? _operationModel;
        public int? OperationMode
        {
            get
            {
                return _operationModel;
            }
            set
            {
                _operationModel = value;

                if (_operationModel.HasValue)
                {
                    _oprationType = (OperationType)value;
                }
            }
        }
        public DateTime? SignDate { get; set; }

        public DateTime? EffectiveDate { get; set; }

        public DateTime? ExpirationDate { get; set; }

        public string Remark { get; set; }

        public string Attachment { get; set; }


        public abstract IOperateModel OperateModel { get; }
        /// <summary>
        /// 代理范围
        /// </summary>
        public IList<AgreementScope> ProxyScope { get; set; }
        /// <summary>
        /// 产品信息
        /// </summary>
        public ProductInfo ProductInfo { get; set; }
        /// <summary>
        /// 必填项验证
        /// </summary>
        public virtual void RquireValidate()
        {

            if (!this.OperationMode.HasValue)
            {
                throw new Exception("操作模式必选");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.logic.Agreement
{
   public  class RebateModel:IOperateModel
    {
         public decimal RebatePrice { get; set; }

         public decimal BindingPrice { get; set; }


        public string RebateRemark { get; set; }

        public decimal RebateRatio { get; set; }
    }
}

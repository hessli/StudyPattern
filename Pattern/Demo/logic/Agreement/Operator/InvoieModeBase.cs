using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.logic.Agreement
{
    /// <summary>
    /// 高开模式
    /// </summary>
   public abstract class InvoieModeBase: IOperateModel
    {

            public decimal InvoicePrice { get; set; }

            public decimal InvestmentPrice { get; set; }


            public decimal TallagePrice { get; set; }


           public string TallageRemark { get; set; }
    }
}
 
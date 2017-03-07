using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.logic.Agreement
{
  public  class SupplierInvoiceModel:InvoieModeBase
    {
         public int RefundType { get; set; }

         public string RefundRemark { get; set; }
    }
}

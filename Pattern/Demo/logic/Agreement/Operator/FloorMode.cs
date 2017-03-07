using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.logic.Agreement
{
    /// <summary>
    /// 底价模式
    /// </summary>
   public class FloorMode: IOperateModel
    {
        public decimal FloorPrice { get; set; }

        public decimal PublicPrice { get; set; }

        public decimal PrivatePrice { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.logic.Agreement
{
  public  class ProductInfo
    {
        public int ProductId { get; set; }

        public string ProductName { get; set; }
        /// <summary>
        /// 整件包装
        /// </summary>
        public int WholePackage { get; set; }
        /// <summary>
        /// 厂家
        /// </summary>
        public Guid ManufacturerId { get; set; }
        /// <summary>
        /// 厂家名
        /// </summary>
        public string Manufacturer { get; set; }
    }
}

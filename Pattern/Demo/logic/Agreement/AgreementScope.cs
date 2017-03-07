using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.logic.Agreement
{
    /// <summary>
    /// 协议产品范围
    /// </summary>
    public class AgreementScope
    {
        public Guid Id { get; set; }

        public string Province { get; set; }

        public string City { get; set; }

        public string Country { get; set; }

        public string Area { get; set; }

        public string TerminalIds { get; set; }
        public string TerminalNames
        {
            get
            {
                return "";
            }
        }
    }
}

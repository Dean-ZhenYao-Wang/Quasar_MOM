using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Domain.CoreComponents
{
    /// <summary>
    /// 用于任何需要货币单位的元素
    /// </summary>
    public struct AmountType
    {
        /// <summary>
        /// 金额
        /// </summary>
        public decimal Value { get; set; }
        /// <summary>
        /// 货币编号
        /// </summary>
        public string CurrencyID { get; set; }
    }
}

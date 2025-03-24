using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOM.Domain.B2MML.CoreComponents
{
    /// <summary>
    /// 国家货币代码<br>see:https://www.iban.hk/currency-codes</br>
    /// </summary>
    public class CurrencyCodes
    {
        /// <summary>
        /// 国家名称
        /// </summary>
        public required string CountryName { get; set; }
        /// <summary>
        /// 货币名称
        /// </summary>
        public required string CurrencyName { get; set; }
        /// <summary>
        /// 货币代码
        /// </summary>
        public required string CurrencyCode{get;set;}
        /// <summary>
        /// 货币编号
        /// </summary>
        public required string CurrencyID { get; set; }
    }
}

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Weblitz.Shop.Web.Models.View
{
    public class AccountSummary
    {
        public bool IsAuthenticated { get; set; }
        public string UserName { get; set; }
        public IDictionary<int, string> LanguageList { get; set; }
        public int LanguageId { get; set; }
        public IDictionary<int, string> CurrencyList { get; set; }
        public int CurrencyId { get; set; }
    }
}
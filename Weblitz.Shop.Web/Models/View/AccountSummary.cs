using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Weblitz.Shop.Web.Models.View
{
    public class AccountSummary
    {
        public bool IsAuthenticated { get; set; }
        public string UserName { get; set; }
        public SelectList LanguageList { get; set; }
        public int LanguageId { get; set; }
        public SelectList CurrencyList { get; set; }
        public int CurrencyId { get; set; }
    }
}
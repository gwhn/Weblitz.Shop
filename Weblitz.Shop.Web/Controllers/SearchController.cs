using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Weblitz.Shop.Web.Controllers
{
    public class SearchController : Controller
    {
        //
        // GET: /Search/
        [ChildActionOnly]
        public PartialViewResult Index()
        {
            return PartialView();
        }

        public ActionResult Results(string expression)
        {
            throw new NotImplementedException();
        }
    }
}

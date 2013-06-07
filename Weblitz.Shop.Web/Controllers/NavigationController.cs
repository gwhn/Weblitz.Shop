using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Weblitz.Shop.Web.Controllers
{
    public class NavigationController : Controller
    {
        //
        // GET: /Navigation/
        [ChildActionOnly]
        public PartialViewResult Index()
        {
            return PartialView();
        }

        // 
        // GET: /Navigation/Menu
        [ChildActionOnly]
        public PartialViewResult Menu()
        {
            return PartialView();
        }

        // 
        // GET: /Navigation/SiteMap
        [ChildActionOnly]
        public PartialViewResult SiteMap()
        {
            return PartialView();
        }
    }
}

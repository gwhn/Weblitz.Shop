using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Weblitz.Shop.Web.Filters;
using Weblitz.Shop.Web.Models.View;

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
        [SetupMenu]
        public PartialViewResult Menu()
        {
            return PartialView();
        }

        // 
        // GET: /Navigation/SiteMap
        [ChildActionOnly]
        [SetupSiteMap]
        public PartialViewResult SiteMap()
        {
            return PartialView();
        }
    }
}

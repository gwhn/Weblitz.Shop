using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Weblitz.Shop.Web.Controllers
{
    public class ShopController : Controller
    {
        //
        // GET: /Shop/
        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /Shop/About
        [ChildActionOnly]
        public PartialViewResult About()
        {
            return PartialView();
        }

        //
        // GET: /Shop/Contact
        [ChildActionOnly]
        public PartialViewResult Contact()
        {
            return PartialView();
        }

    }
}

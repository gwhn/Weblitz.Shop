using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Weblitz.Shop.Web.Models.View;

namespace Weblitz.Shop.Web.Controllers
{
    public class ShopController : Controller
    {
        //
        // GET: /Shop/
        public ActionResult Index()
        {
            return View(new ShopFront
                {
                    SectionId = string.Format("{0}_{1}", RouteData.Values["Controller"], RouteData.Values["Action"]),
                    CurrentYear = DateTime.Now.Year.ToString(CultureInfo.InvariantCulture),
                    Title = "Weblitz"
                });
        }

        //
        // GET: /Shop/Checkout
        public ActionResult Checkout()
        {
            throw new NotImplementedException();
        }

        //
        // GET: /Shop/CartSummary
        [ChildActionOnly]
        public PartialViewResult CartSummary()
        {
            return PartialView(new CartSummary());
        }

        //
        // GET: /Shop/Category/{id}
        public ActionResult Category(int id)
        {
            throw new NotImplementedException();
        }

        //
        // GET: /Shop/About
        [ChildActionOnly]
        public PartialViewResult About()
        {
            return PartialView();
        }
    }
}

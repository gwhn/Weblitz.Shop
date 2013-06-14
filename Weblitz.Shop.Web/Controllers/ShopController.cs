using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Weblitz.Shop.Web.Filters;
using Weblitz.Shop.Web.Models.View;

namespace Weblitz.Shop.Web.Controllers
{
    public class ShopController : ApplicationController
    {
        //
        // GET: /Shop/
        [ShopFrontFilter]
        public ActionResult Index()
        {
            return View();
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
        [CategoryFilter]
        public ActionResult Category(int id)
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
        // GET: /Shop/Buy/{id}
        public ActionResult Buy(int id)
        {
            throw new NotImplementedException();
        }

        //
        // GET: /Shop/Wishlist/{id}
        public ActionResult Wishlist(int id)
        {
            throw new NotImplementedException();
        }

        //
        // GET: /Shop/Compare/{id}
        public ActionResult Compare(int id)
        {
            throw new NotImplementedException();
        }

        //
        // GET: /Shop/Product/{id}
        public ActionResult Product(int id)
        {
            throw new NotImplementedException();
        }
    }
}

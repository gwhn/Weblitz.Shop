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
        [SetupHomePage]
        public ViewResult Index()
        {
            var page = ViewData.Model as HomePage;
            if (page != null)
            {
                page.FeaturedMedia.Container.Items = Db.ProductSummaries.Take(3).ToList();
                page.LatestMedia.Container.Items = Db.ProductSummaries.Skip(3).Take(3).ToList();
                page.SaleMedia.Container.Items = Db.ProductSummaries.Skip(6).Take(3).ToList();
                page.FeaturedThumbnails.Container.Items = Db.ProductSummaries.Take(12).ToList();
                page.LatestThumbnails.Container.Items = Db.ProductSummaries.Skip(3).Take(12).ToList();
                page.SaleThumbnails.Container.Items = Db.ProductSummaries.Skip(6).Take(12).ToList();
            }
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
        [SetupCategoryPage]
        public ViewResult Category(int id)
        {
            var page = ViewData.Model as CategoryPage;
            if (page != null)
            {
                page.Sidebar.Name = "Some Category";
                page.Sidebar.Children = Db.CategorySummaries;
                page.Container.Items = Db.ProductSummaries;
            }
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

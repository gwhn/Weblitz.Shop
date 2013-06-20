using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Weblitz.Shop.Web.Filters;
using Weblitz.Shop.Web.Models.View;

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

        //
        // GET: /Search/Results/{query}
        [SetupResultsPage]
        public ViewResult Results(string query)
        {
            var page = ViewData.Model as ResultsPage;
            if (page != null)
            {
                page.Query = query;
                page.Sidebar.Name = "Some category";
                page.Sidebar.Children = Db.CategorySummaries;
                page.Container.Items = Db.ProductSummaries;
            }
            return View();
        }
    }
}

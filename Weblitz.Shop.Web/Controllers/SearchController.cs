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
                page.Sidebar.CategoryFilter = new CategoryFilter
                    {
                        Name = "Some category",
                        Children = Db.CategorySummaries
                    };
                page.Sidebar.PriceFilter.PriceRanges.Single(x => x.From == 0M).Count = 54;
                page.Sidebar.PriceFilter.PriceRanges.Single(x => x.From == 100M).Count = 43;
                page.Sidebar.PriceFilter.PriceRanges.Single(x => x.From == 200M).Count = 32;
                page.Container.Items = Db.ProductSummaries;
            }
            return View();
        }
    }
}

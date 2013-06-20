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
        // GET: /Search/Results/{expression}
        [SetupResultsPage]
        public ViewResult Results(string expression)
        {
            var page = ViewData.Model as ResultsPage;
            if (page != null)
            {
                
            }
            return View();
        }
    }
}

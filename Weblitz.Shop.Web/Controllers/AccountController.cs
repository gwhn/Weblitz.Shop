using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Weblitz.Shop.Web.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/
        [ChildActionOnly]
        public PartialViewResult Index()
        {
            return PartialView();
        }
    }
}

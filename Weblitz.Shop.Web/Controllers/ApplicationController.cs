using System.Web.Mvc;

namespace Weblitz.Shop.Web.Controllers
{
    public abstract class ApplicationController : Controller
    {
        protected string SectionId
        {
            get { return string.Format("{0}_{1}", RouteData.Values["Controller"], RouteData.Values["Action"]); }
        }
    }
}
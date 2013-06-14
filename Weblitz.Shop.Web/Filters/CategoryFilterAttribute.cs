using System.Collections.Generic;
using System.Web.Mvc;
using Weblitz.Shop.Web.Models.View;

namespace Weblitz.Shop.Web.Filters
{
    public class CategoryFilterAttribute : PageFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.Controller.ViewData.Model = new CategoryPage
                {
                    Title = "Category",
                    SectionId = base.SectionId,
                    Trail = new Trail
                        {
                            UrlReferer = filterContext.HttpContext.Request.UrlReferrer,
                            Breadcrumbs = new List<Link>
                                {
                                    new Link
                                        {
                                            LinkText = "Home",
                                            ActionName = "Index",
                                            ControllerName = "Shop"
                                        },
                                    new Link
                                        {
                                            LinkText = "Category"
                                        }
                                }
                        }
                };
            base.OnActionExecuting(filterContext);
        }
    }
}
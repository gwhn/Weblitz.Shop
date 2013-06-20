using System.Collections.Generic;
using System.Web.Mvc;
using Weblitz.Shop.Web.Models.View;

namespace Weblitz.Shop.Web.Filters
{
    public class SetupCategoryPageAttribute : PageFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.Controller.ViewData.Model = new CategoryPage
                {
                    Title = "Category",
                    SectionId = base.SectionId,
                    CurrentPage = 1,
                    PageCount = 5,
                    ItemsPerPage = 25,
                    PerPageOptions = new[] {25, 50, 100},
                    PageLink = new Link(),
                    WindowSize = 5,
                    ViewMode = ViewMode.List,
                    SortBy = "name_asc",
                    SortOptions = new Dictionary<string, string>
                        {
                            {"name_asc", "Name (ascending)"},
                            {"name_desc", "Name (descending)"},
                            {"price_asc", "Price (lowest)"},
                            {"price_desc", "Price (highest)"}
                        },
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
                        },
                    Sidebar = new CategorySidebar {Name = "Some Category"},
                    Container = new Container<ProductSummary> {GroupCount = 4}
                };
            base.OnActionExecuting(filterContext);
        }
    }
}
using System.Collections.Generic;
using System.Web.Mvc;
using Weblitz.Shop.Web.Models.View;

namespace Weblitz.Shop.Web.Filters
{
    public class SetupCategoryPageAttribute : SetupPageAttribute
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
                    Sidebar = new Sidebar
                        {
                            PriceFilter = new PriceFilter
                                {
                                    PriceRanges = new List<PriceRange>
                                        {
                                            new PriceRange
                                                {
                                                    Link = new Link {RouteValues = new {filter = "price", from = 0M}},
                                                    From = 0M
                                                },
                                            new PriceRange
                                                {
                                                    Link = new Link {RouteValues = new {filter = "price", from = 100M}},
                                                    From = 100M
                                                },
                                            new PriceRange
                                                {
                                                    Link = new Link {RouteValues = new {filter = "price", from = 200M}},
                                                    From = 200M
                                                }
                                        }
                                }
                        },
                    Container = new Container<ProductSummary> {GroupCount = 4}
                };
            base.OnActionExecuting(filterContext);
        }
    }
}
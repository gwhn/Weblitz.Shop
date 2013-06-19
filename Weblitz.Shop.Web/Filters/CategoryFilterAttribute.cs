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
                    CurrentPage = 1,
                    PageCount = 5,
                    ItemsPerPage = 10,
                    PageLink = new Link
                        {
                            ActionName = "Category",
                            ControllerName = "Shop"
                        },
                    WindowSize = 5,
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
                    Sidebar = new CategorySidebar
                        {
                            Name = "Some Category",
                            Children = new List<CategorySummary>
                                {
                                    new CategorySummary
                                        {
                                            Link = new Link
                                                {
                                                    LinkText = "Sub category 1",
                                                    ActionName = "Category",
                                                    ControllerName = "Shop",
                                                    RouteValues = new {id = 1}
                                                },
                                            Count = 123
                                        },
                                    new CategorySummary
                                        {
                                            Link = new Link
                                                {
                                                    LinkText = "Sub category 2",
                                                    ActionName = "Category",
                                                    ControllerName = "Shop",
                                                    RouteValues = new {id = 2}
                                                },
                                            Count = 234
                                        }
                                }
                        }
                };
            base.OnActionExecuting(filterContext);
        }
    }
}
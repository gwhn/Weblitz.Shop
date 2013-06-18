using System.Collections.ObjectModel;
using System.Web.Mvc;
using Weblitz.Shop.Web.Models.View;

namespace Weblitz.Shop.Web.Filters
{
    public class MenuFilterAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.Controller.ViewData.Model = new Collection<MenuItem>
                {
                    new MenuItem
                        {
                            Id = 1,
                            Name = "Category 1",
                            Children = new Collection<MenuItem>
                                {
                                    new MenuItem {Id = 2, Name = "Category 1.1"},
                                    new MenuItem
                                        {
                                            Id = 3,
                                            Name = "Category 1.2",
                                            Children = new Collection<MenuItem>
                                                {
                                                    new MenuItem {Id = 4, Name = "Category 1.2.1"},
                                                    new MenuItem {Id = 5, Name = "Category 1.2.2"}
                                                }
                                        },
                                    new MenuItem {Id = 6, Name = "Category 1.3"}
                                }
                        },
                    new MenuItem
                        {
                            Id = 7,
                            Name = "Category 2",
                            Children = new Collection<MenuItem>
                                {
                                    new MenuItem {Id = 8, Name = "Category 2.1"},
                                    new MenuItem
                                        {
                                            Id = 9,
                                            Name = "Category 2.2",
                                            Children = new Collection<MenuItem>
                                                {
                                                    new MenuItem {Id = 10, Name = "Category 2.2.1"},
                                                    new MenuItem {Id = 11, Name = "Category 2.2.2"}
                                                }
                                        }
                                }
                        },
                    new MenuItem
                        {
                            Id = 12,
                            Name = "Category 3",
                            Children = new Collection<MenuItem>
                                {
                                    new MenuItem {Id = 13, Name = "Category 3.1"}
                                }
                        },
                    new MenuItem
                        {
                            Id = 14,
                            Name = "Category 4"
                        }
                };
            base.OnActionExecuting(filterContext);
        }
    }
}
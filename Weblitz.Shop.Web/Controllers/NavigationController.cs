using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Weblitz.Shop.Web.Models.View;

namespace Weblitz.Shop.Web.Controllers
{
    public class NavigationController : Controller
    {
        //
        // GET: /Navigation/
        [ChildActionOnly]
        public PartialViewResult Index()
        {
            return PartialView();
        }

        // 
        // GET: /Navigation/Menu
        [ChildActionOnly]
        public PartialViewResult Menu()
        {
            return PartialView(new Collection<MenuItem>
                {
                    new MenuItem
                        {
                            Id = 1,
                            Name = "Category 1",
                            Children = new Collection<MenuItem>
                                {
                                    new MenuItem {Id = 2, Name = "Category 1.1"},
                                    new MenuItem {Id = 3, Name = "Category 1.2"},
                                    new MenuItem {Id = 4, Name = "Category 1.3"}
                                }
                        },
                    new MenuItem
                        {
                            Id = 5,
                            Name = "Category 2",
                            Children = new Collection<MenuItem>
                                {
                                    new MenuItem {Id = 6, Name = "Category 2.1"},
                                    new MenuItem {Id = 7, Name = "Category 2.2"}
                                }
                        },
                    new MenuItem
                        {
                            Id = 8,
                            Name = "Category 3",
                            Children = new Collection<MenuItem>
                                {
                                    new MenuItem {Id = 9, Name = "Category 3.1"}
                                }
                        },
                    new MenuItem
                        {
                            Id = 10,
                            Name = "Category 4"
                        }
                });
        }

        // 
        // GET: /Navigation/SiteMap
        [ChildActionOnly]
        public PartialViewResult SiteMap()
        {
            return PartialView();
        }
    }
}

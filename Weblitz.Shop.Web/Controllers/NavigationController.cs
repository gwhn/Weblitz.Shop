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
                                                    new MenuItem{Id = 10, Name = "Category 2.2.1"},
                                                    new MenuItem{Id = 11, Name = "Category 2.2.2"}
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
                });
        }

        // 
        // GET: /Navigation/SiteMap
        [ChildActionOnly]
        public PartialViewResult SiteMap()
        {
            return PartialView(new List<Section>
                {
                    new Section
                        {
                            Name = "Information",
                            Links = new Collection<Link>
                                {
                                    new Link
                                        {
                                            LinkText = "About", 
                                            ActionName = "About", 
                                            ControllerName = "Shop"
                                        },
                                    new Link
                                        {
                                            LinkText = "Delivery Information",
                                            ActionName = "Delivery",
                                            ControllerName = "Shop"
                                        },
                                    new Link
                                        {
                                            LinkText = "Privacy Policy",
                                            ActionName = "Privacy",
                                            ControllerName = "Shop"
                                        },
                                    new Link
                                        {
                                            LinkText = "Terms & Conditions",
                                            ActionName = "Terms",
                                            ControllerName = "Shop"
                                        }
                                }
                        },
                    new Section
                        {
                            Name = "Customer Service",
                            Links = new Collection<Link>
                                {
                                    new Link
                                        {
                                            LinkText = "Contact Us", 
                                            ActionName = "Contact", 
                                            ControllerName = "Shop"
                                        },
                                    new Link
                                        {
                                            LinkText = "Returns", 
                                            ActionName = "Returns", 
                                            ControllerName = "Shop"
                                        }
                                }
                        },
                    new Section
                        {
                            Name = "Extras",
                            Links = new Collection<Link>
                                {
                                    new Link
                                        {
                                            LinkText = "Brands", 
                                            ActionName = "Brands", 
                                            ControllerName = "Shop"
                                        },
                                    new Link
                                        {
                                            LinkText = "Gift Vouchers",
                                            ActionName = "Vouchers",
                                            ControllerName = "Shop"
                                        },
                                    new Link
                                        {
                                            LinkText = "Affiliates",
                                            ActionName = "Affiliates",
                                            ControllerName = "Shop"
                                        },
                                    new Link
                                        {
                                            LinkText = "Specials", 
                                            ActionName = "Specials", 
                                            ControllerName = "Shop"
                                        }
                                }
                        }
                });
        }
    }
}

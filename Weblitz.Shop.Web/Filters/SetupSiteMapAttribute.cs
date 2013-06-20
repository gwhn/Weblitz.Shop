using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Web.Mvc;
using Weblitz.Shop.Web.Models.View;

namespace Weblitz.Shop.Web.Filters
{
    public class SetupSiteMapAttribute : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.Controller.ViewData.Model = new List<Section>
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
                };
            base.OnActionExecuting(filterContext);
        }
    }
}
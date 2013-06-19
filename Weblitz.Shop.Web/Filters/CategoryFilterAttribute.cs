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
                    PageLink = new Link(),
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
                        },
                    Container = new Container<ProductSummary>
                        {
                            GroupCount = 4,
                            Items = new List<ProductSummary>
                                {
                                    new ProductSummary
                                        {
                                            Id = 1,
                                            Title = "Featured Product 1",
                                            Price = 1.23M,
                                            DicountedPrice = 2.34M,
                                            IsNew = true,
                                            Image = new Image
                                                {
                                                    Source = "/Content/Images/products/product_1_small.jpg"
                                                },
                                            Link = new Link
                                                {
                                                    LinkText = "View",
                                                    ActionName = "Product",
                                                    ControllerName = "Shop"
                                                }
                                        },
                                    new ProductSummary
                                        {
                                            Id = 2,
                                            Title = "Featured Product 2",
                                            Price = 2.34M,
                                            IsNew = true,
                                            Image = new Image
                                                {
                                                    Source = "/Content/Images/products/product_2_small.jpg"
                                                },
                                            Link = new Link
                                                {
                                                    LinkText = "View",
                                                    ActionName = "Product",
                                                    ControllerName = "Shop"
                                                }
                                        },
                                    new ProductSummary
                                        {
                                            Id = 3,
                                            Title = "Featured Product 3",
                                            Price = 3.45M,
                                            DicountedPrice = 4.56M,
                                            Image = new Image
                                                {
                                                    Source = "/Content/Images/products/product_3_small.jpg"
                                                },
                                            Link = new Link
                                                {
                                                    LinkText = "View",
                                                    ActionName = "Product",
                                                    ControllerName = "Shop"
                                                }
                                        },
                                    new ProductSummary
                                        {
                                            Id = 4,
                                            Title = "Featured Product 4",
                                            Price = 4.56M,
                                            Image = new Image
                                                {
                                                    Source = "/Content/Images/products/product_4_small.jpg"
                                                },
                                            Link = new Link
                                                {
                                                    LinkText = "View",
                                                    ActionName = "Product",
                                                    ControllerName = "Shop"
                                                }
                                        },
                                    new ProductSummary
                                        {
                                            Id = 5,
                                            Title = "Featured Product 5",
                                            Price = 5.67M,
                                            Image = new Image
                                                {
                                                    Source = "/Content/Images/products/product_5_small.jpg"
                                                },
                                            Link = new Link
                                                {
                                                    LinkText = "View",
                                                    ActionName = "Product",
                                                    ControllerName = "Shop"
                                                }
                                        },
                                    new ProductSummary
                                        {
                                            Id = 6,
                                            Title = "Featured Product 6",
                                            Price = 6.78M,
                                            Image = new Image
                                                {
                                                    Source = "/Content/Images/products/product_6_small.jpg"
                                                },
                                            Link = new Link
                                                {
                                                    LinkText = "View",
                                                    ActionName = "Product",
                                                    ControllerName = "Shop"
                                                }
                                        },
                                    new ProductSummary
                                        {
                                            Id = 7,
                                            Title = "Latest Product 7",
                                            IsNew = true,
                                            Price = 1.23M,
                                            Image = new Image
                                                {
                                                    Source = "/Content/Images/products/product_1_small.jpg"
                                                },
                                            Link = new Link
                                                {
                                                    LinkText = "View",
                                                    ActionName = "Product",
                                                    ControllerName = "Shop"
                                                }
                                        },
                                    new ProductSummary
                                        {
                                            Id = 8,
                                            Title = "Latest Product 8",
                                            IsNew = true,
                                            Price = 2.34M,
                                            Image = new Image
                                                {
                                                    Source = "/Content/Images/products/product_2_small.jpg"
                                                },
                                            Link = new Link
                                                {
                                                    LinkText = "View",
                                                    ActionName = "Product",
                                                    ControllerName = "Shop"
                                                }
                                        },
                                    new ProductSummary
                                        {
                                            Id = 9,
                                            Title = "Latest Product 9",
                                            IsNew = true,
                                            Price = 3.45M,
                                            Image = new Image
                                                {
                                                    Source = "/Content/Images/products/product_3_small.jpg"
                                                },
                                            Link = new Link
                                                {
                                                    LinkText = "View",
                                                    ActionName = "Product",
                                                    ControllerName = "Shop"
                                                }
                                        },
                                    new ProductSummary
                                        {
                                            Id = 10,
                                            Title = "Latest Product 10",
                                            IsNew = true,
                                            Price = 4.56M,
                                            Image = new Image
                                                {
                                                    Source = "/Content/Images/products/product_4_small.jpg"
                                                },
                                            Link = new Link
                                                {
                                                    LinkText = "View",
                                                    ActionName = "Product",
                                                    ControllerName = "Shop"
                                                }
                                        },
                                    new ProductSummary
                                        {
                                            Id = 11,
                                            Title = "Latest Product 11",
                                            IsNew = true,
                                            Price = 5.67M,
                                            Image = new Image
                                                {
                                                    Source = "/Content/Images/products/product_5_small.jpg"
                                                },
                                            Link = new Link
                                                {
                                                    LinkText = "View",
                                                    ActionName = "Product",
                                                    ControllerName = "Shop"
                                                }
                                        },
                                    new ProductSummary
                                        {
                                            Id = 12,
                                            Title = "Latest Product 12",
                                            IsNew = true,
                                            Price = 6.78M,
                                            Image = new Image
                                                {
                                                    Source = "/Content/Images/products/product_6_small.jpg"
                                                },
                                            Link = new Link
                                                {
                                                    LinkText = "View",
                                                    ActionName = "Product",
                                                    ControllerName = "Shop"
                                                }
                                        },
                                    new ProductSummary
                                        {
                                            Id = 13,
                                            Title = "Sale Product 13",
                                            Price = 2.34M,
                                            DicountedPrice = 1.23M,
                                            Image = new Image
                                                {
                                                    Source = "/Content/Images/products/product_1_small.jpg"
                                                },
                                            Link = new Link
                                                {
                                                    LinkText = "View",
                                                    ActionName = "Product",
                                                    ControllerName = "Shop"
                                                }
                                        },
                                    new ProductSummary
                                        {
                                            Id = 14,
                                            Title = "Sale Product 14",
                                            Price = 3.45M,
                                            DicountedPrice = 2.34M,
                                            Image = new Image
                                                {
                                                    Source = "/Content/Images/products/product_2_small.jpg"
                                                },
                                            Link = new Link
                                                {
                                                    LinkText = "View",
                                                    ActionName = "Product",
                                                    ControllerName = "Shop"
                                                }
                                        },
                                    new ProductSummary
                                        {
                                            Id = 15,
                                            Title = "Sale Product 15",
                                            Price = 4.56M,
                                            DicountedPrice = 3.45M,
                                            Image = new Image
                                                {
                                                    Source = "/Content/Images/products/product_3_small.jpg"
                                                },
                                            Link = new Link
                                                {
                                                    LinkText = "View",
                                                    ActionName = "Product",
                                                    ControllerName = "Shop"
                                                }
                                        },
                                    new ProductSummary
                                        {
                                            Id = 16,
                                            Title = "Sale Product 16",
                                            Price = 5.67M,
                                            DicountedPrice = 4.56M,
                                            Image = new Image
                                                {
                                                    Source = "/Content/Images/products/product_4_small.jpg"
                                                },
                                            Link = new Link
                                                {
                                                    LinkText = "View",
                                                    ActionName = "Product",
                                                    ControllerName = "Shop"
                                                }
                                        },
                                    new ProductSummary
                                        {
                                            Id = 17,
                                            Title = "Sale Product 17",
                                            Price = 6.78M,
                                            DicountedPrice = 5.67M,
                                            Image = new Image
                                                {
                                                    Source = "/Content/Images/products/product_5_small.jpg"
                                                },
                                            Link = new Link
                                                {
                                                    LinkText = "View",
                                                    ActionName = "Product",
                                                    ControllerName = "Shop"
                                                }
                                        },
                                    new ProductSummary
                                        {
                                            Id = 18,
                                            Title = "Sale Product 18",
                                            Price = 7.89M,
                                            DicountedPrice = 6.78M,
                                            Image = new Image
                                                {
                                                    Source = "/Content/Images/products/product_6_small.jpg"
                                                },
                                            Link = new Link
                                                {
                                                    LinkText = "View",
                                                    ActionName = "Product",
                                                    ControllerName = "Shop"
                                                }
                                        }
                                }
                        },
                };
            base.OnActionExecuting(filterContext);
        }
    }
}
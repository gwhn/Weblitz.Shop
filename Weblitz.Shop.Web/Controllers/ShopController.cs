using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Weblitz.Shop.Web.Models.View;

namespace Weblitz.Shop.Web.Controllers
{
    public class ShopController : Controller
    {
        //
        // GET: /Shop/
        public ActionResult Index()
        {
            return View(new ShopFront
                {
                    SectionId = string.Format("{0}_{1}", RouteData.Values["Controller"], RouteData.Values["Action"]),
                    CurrentYear = DateTime.Now.Year.ToString(CultureInfo.InvariantCulture),
                    Title = "Weblitz",
                    FeaturedProducts = new Carousel
                        {
                            TargetId = "FeaturedProducts",
                            IndicatorsVisible = true,
                            Items = new List<Carousel.Item>
                                {
                                    new Carousel.Item
                                        {
                                            Image = new Image
                                                {
                                                    Source = "Content/Images/slides/large/slide_001.jpg"
                                                },
                                            Link = new Link
                                                {
                                                    LinkText = "View",
                                                    ActionName = "Product",
                                                    ControllerName = "Shop",
                                                    RouteValues = new {id = 1}
                                                },
                                            Title = "Featured Product 1",
                                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit fusce vel sapien elit in malesuada semper mi, id sollicitudin urna fermentum ut fusce varius nisl ac ipsum gravida vel pretium tellus."
                                        },
                                    new Carousel.Item
                                        {
                                            Image = new Image
                                                {
                                                    Source = "Content/Images/slides/large/slide_002.jpg"
                                                },
                                            ImageAlignment = Carousel.Item.Alignment.Right,
                                            Link = new Link
                                                {
                                                    LinkText = "View",
                                                    ActionName = "Product",
                                                    ControllerName = "Shop",
                                                    RouteValues = new {id = 2}
                                                },
                                            Title = "Featured Product 2",
                                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit fusce vel sapien elit in malesuada semper mi, id sollicitudin urna fermentum ut fusce varius nisl ac ipsum gravida vel pretium tellus."
                                        },
                                    new Carousel.Item
                                        {
                                            Image = new Image
                                                {
                                                    Source = "Content/Images/slides/large/slide_003.jpg"
                                                },
                                            Link = new Link
                                                {
                                                    LinkText = "View",
                                                    ActionName = "Product",
                                                    ControllerName = "Shop",
                                                    RouteValues = new {id = 3}
                                                },
                                            Title = "Featured Product 3",
                                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit fusce vel sapien elit in malesuada semper mi, id sollicitudin urna fermentum ut fusce varius nisl ac ipsum gravida vel pretium tellus."
                                        },
                                }
                        },
                    NewProducts = new Carousel
                        {
                            TargetId = "NewProducts",
                            Items = new List<Carousel.Item>
                                {
                                    new Carousel.Item
                                        {
                                            Image = new Image
                                                {
                                                    Source = "Content/Images/slides/small/slide_001.jpg"
                                                },
                                            ImageAlignment = Carousel.Item.Alignment.Right,
                                            Link = new Link
                                                {
                                                    LinkText = "View",
                                                    ActionName = "Product",
                                                    ControllerName = "Shop",
                                                    RouteValues = new {id = 1}
                                                },
                                            Title = "New Product 1"
                                        },
                                    new Carousel.Item
                                        {
                                            Image = new Image
                                                {
                                                    Source = "Content/Images/slides/small/slide_002.jpg"
                                                },
                                            Link = new Link
                                                {
                                                    LinkText = "View",
                                                    ActionName = "Product",
                                                    ControllerName = "Shop",
                                                    RouteValues = new {id = 2}
                                                },
                                            Title = "New Product 2"
                                        },
                                    new Carousel.Item
                                        {
                                            Image = new Image
                                                {
                                                    Source = "Content/Images/slides/small/slide_003.jpg"
                                                },
                                            ImageAlignment = Carousel.Item.Alignment.Right,
                                            Link = new Link
                                                {
                                                    LinkText = "View",
                                                    ActionName = "Product",
                                                    ControllerName = "Shop",
                                                    RouteValues = new {id = 3}
                                                },
                                            Title = "New Product 3"
                                        },
                                }
                        },
                    SaleProducts = new Carousel
                        {
                            TargetId = "SaleProducts",
                            Items = new List<Carousel.Item>
                                {
                                    new Carousel.Item
                                        {
                                            Image = new Image
                                                {
                                                    Source = "Content/Images/slides/small/slide_001.jpg"
                                                },
                                            Link = new Link
                                                {
                                                    LinkText = "View",
                                                    ActionName = "Product",
                                                    ControllerName = "Shop",
                                                    RouteValues = new {id = 1}
                                                },
                                            Title = "Sale Product 1"
                                        },
                                    new Carousel.Item
                                        {
                                            Image = new Image
                                                {
                                                    Source = "Content/Images/slides/small/slide_002.jpg"
                                                },
                                            ImageAlignment = Carousel.Item.Alignment.Right,
                                            Link = new Link
                                                {
                                                    LinkText = "View",
                                                    ActionName = "Product",
                                                    ControllerName = "Shop",
                                                    RouteValues = new {id = 2}
                                                },
                                            Title = "Sale Product 2"
                                        },
                                    new Carousel.Item
                                        {
                                            Image = new Image
                                                {
                                                    Source = "Content/Images/slides/small/slide_003.jpg"
                                                },
                                            Link = new Link
                                                {
                                                    LinkText = "View",
                                                    ActionName = "Product",
                                                    ControllerName = "Shop",
                                                    RouteValues = new {id = 3}
                                                },
                                            Title = "Sale Product 3"
                                        },
                                }
                        }
                });
        }

        //
        // GET: /Shop/Checkout
        public ActionResult Checkout()
        {
            throw new NotImplementedException();
        }

        //
        // GET: /Shop/CartSummary
        [ChildActionOnly]
        public PartialViewResult CartSummary()
        {
            return PartialView(new CartSummary());
        }

        //
        // GET: /Shop/Category/{id}
        public ActionResult Category(int id)
        {
            throw new NotImplementedException();
        }

        //
        // GET: /Shop/About
        [ChildActionOnly]
        public PartialViewResult About()
        {
            return PartialView();
        }
    }
}

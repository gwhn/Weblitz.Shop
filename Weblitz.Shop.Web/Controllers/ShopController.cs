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
                    FeaturedCarousel = new Carousel
                        {
                            TargetId = "FeaturedCarousel",
                            IndicatorsVisible = true,
                            Items = new List<Carousel.Item>
                                {
                                    new Carousel.Item
                                        {
                                            Image = new Image
                                                {
                                                    Source = "Content/Images/products/product_1_medium.jpg"
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
                                                    Source = "Content/Images/products/product_2_medium.jpg"
                                                },
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
                                                    Source = "Content/Images/products/product_3_medium.jpg"
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
                    LatestCarousel = new Carousel
                        {
                            TargetId = "LatestCarousel",
                            Items = new List<Carousel.Item>
                                {
                                    new Carousel.Item
                                        {
                                            Image = new Image
                                                {
                                                    Source = "Content/Images/products/product_4_small.jpg"
                                                },
                                            ImageAlignment = Carousel.Item.Alignment.Right,
                                            Link = new Link
                                                {
                                                    LinkText = "View",
                                                    ActionName = "Product",
                                                    ControllerName = "Shop",
                                                    RouteValues = new {id = 1}
                                                },
                                            Title = "New Product 1",
                                            Text = "Lorem malesuada semper mi, id sollicitudin urna ipsum"
                                        },
                                    new Carousel.Item
                                        {
                                            Image = new Image
                                                {
                                                    Source = "Content/Images/products/product_5_small.jpg"
                                                },
                                            ImageAlignment = Carousel.Item.Alignment.Right,
                                            Link = new Link
                                                {
                                                    LinkText = "View",
                                                    ActionName = "Product",
                                                    ControllerName = "Shop",
                                                    RouteValues = new {id = 2}
                                                },
                                            Title = "New Product 2",
                                            Text = "Lorem ipsum dolor sit amet vel fusce varius nisl ac"
                                        },
                                    new Carousel.Item
                                        {
                                            Image = new Image
                                                {
                                                    Source = "Content/Images/products/product_6_small.jpg"
                                                },
                                            ImageAlignment = Carousel.Item.Alignment.Right,
                                            Link = new Link
                                                {
                                                    LinkText = "View",
                                                    ActionName = "Product",
                                                    ControllerName = "Shop",
                                                    RouteValues = new {id = 3}
                                                },
                                            Title = "New Product 3",
                                            Text = "adipiscing elit fusce vel sapien elit in malesuada"
                                        },
                                }
                        },
                    SaleCarousel = new Carousel
                        {
                            TargetId = "SaleCarousel",
                            Items = new List<Carousel.Item>
                                {
                                    new Carousel.Item
                                        {
                                            Image = new Image
                                                {
                                                    Source = "Content/Images/products/product_2_small.jpg"
                                                },
                                            Link = new Link
                                                {
                                                    LinkText = "View",
                                                    ActionName = "Product",
                                                    ControllerName = "Shop",
                                                    RouteValues = new {id = 1}
                                                },
                                            Title = "Sale Product 1",
                                            Text = "elit fusce vel sapien elit in malesuada semper mi"
                                        },
                                    new Carousel.Item
                                        {
                                            Image = new Image
                                                {
                                                    Source = "Content/Images/products/product_3_small.jpg"
                                                },
                                            Link = new Link
                                                {
                                                    LinkText = "View",
                                                    ActionName = "Product",
                                                    ControllerName = "Shop",
                                                    RouteValues = new {id = 2}
                                                },
                                            Title = "Sale Product 2",
                                            Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit"
                                        },
                                    new Carousel.Item
                                        {
                                            Image = new Image
                                                {
                                                    Source = "Content/Images/products/product_4_small.jpg"
                                                },
                                            Link = new Link
                                                {
                                                    LinkText = "View",
                                                    ActionName = "Product",
                                                    ControllerName = "Shop",
                                                    RouteValues = new {id = 3}
                                                },
                                            Title = "Sale Product 3",
                                            Text = "id sollicitudin urna fermentum ut fusce varius nisl ac"
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

using System.Collections.Generic;
using System.Web.Mvc;
using System.Web.Routing;
using Weblitz.Shop.Web.Models.View;

namespace Weblitz.Shop.Web.Filters
{
    public class ShopFrontFilterAttribute : PageFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.Controller.ViewData.Model = new ShopFront
                {
                    SectionId = base.SectionId,
                    FeaturedCarousel = new Carousel
                        {
                            TargetId = "FeaturedCarousel",
                            IndicatorsVisible = true,
                            Container = new Container<ProductSummary>
                                {
                                    GroupCount = 1,
                                    Items = new List<ProductSummary>
                                        {
                                            new ProductSummary
                                                {
                                                    Id = 1,
                                                    Image = new Image
                                                        {
                                                            Source = "Content/Images/products/product_1_medium.jpg"
                                                        },
                                                    Link = new Link
                                                        {
                                                            LinkText = "View",
                                                            ActionName = "Product",
                                                            ControllerName = "Shop",
                                                        },
                                                    Title = "Featured Product 1",
                                                    Text =
                                                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit fusce vel sapien elit in malesuada semper mi, id sollicitudin urna fermentum ut fusce varius nisl ac ipsum gravida vel pretium tellus."
                                                },
                                            new ProductSummary
                                                {
                                                    Id = 2,
                                                    Image = new Image
                                                        {
                                                            Source = "Content/Images/products/product_2_medium.jpg"
                                                        },
                                                    Link = new Link
                                                        {
                                                            LinkText = "View",
                                                            ActionName = "Product",
                                                            ControllerName = "Shop"
                                                        },
                                                    Title = "Featured Product 2",
                                                    Text =
                                                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit fusce vel sapien elit in malesuada semper mi, id sollicitudin urna fermentum ut fusce varius nisl ac ipsum gravida vel pretium tellus."
                                                },
                                            new ProductSummary
                                                {
                                                    Id = 3,
                                                    Image = new Image
                                                        {
                                                            Source = "Content/Images/products/product_3_medium.jpg"
                                                        },
                                                    Link = new Link
                                                        {
                                                            LinkText = "View",
                                                            ActionName = "Product",
                                                            ControllerName = "Shop"
                                                        },
                                                    Title = "Featured Product 3",
                                                    Text =
                                                        "Lorem ipsum dolor sit amet, consectetur adipiscing elit fusce vel sapien elit in malesuada semper mi, id sollicitudin urna fermentum ut fusce varius nisl ac ipsum gravida vel pretium tellus."
                                                }
                                        },
                                }
                        },
                    LatestCarousel = new Carousel
                        {
                            TargetId = "LatestCarousel",
                            Container = new Container<ProductSummary>
                                {
                                    GroupCount = 1,
                                    Items = new List<ProductSummary>
                                        {
                                            new ProductSummary
                                                {
                                                    Id = 1,
                                                    Image = new Image
                                                        {
                                                            Source = "Content/Images/products/product_4_small.jpg",
                                                            Alignment = Image.ImageAlignment.Right,
                                                        },
                                                    Link = new Link
                                                        {
                                                            LinkText = "View",
                                                            ActionName = "Product",
                                                            ControllerName = "Shop"
                                                        },
                                                    Title = "New Product 1",
                                                    Text = "Lorem malesuada semper mi, id sollicitudin urna ipsum"
                                                },
                                            new ProductSummary
                                                {
                                                    Id = 2,
                                                    Image = new Image
                                                        {
                                                            Source = "Content/Images/products/product_5_small.jpg",
                                                            Alignment = Image.ImageAlignment.Right,
                                                        },
                                                    Link = new Link
                                                        {
                                                            LinkText = "View",
                                                            ActionName = "Product",
                                                            ControllerName = "Shop"
                                                        },
                                                    Title = "New Product 2",
                                                    Text = "Lorem ipsum dolor sit amet vel fusce varius nisl ac"
                                                },
                                            new ProductSummary
                                                {
                                                    Id = 3,
                                                    Image = new Image
                                                        {
                                                            Source = "Content/Images/products/product_6_small.jpg",
                                                            Alignment = Image.ImageAlignment.Right,
                                                        },
                                                    Link = new Link
                                                        {
                                                            LinkText = "View",
                                                            ActionName = "Product",
                                                            ControllerName = "Shop"
                                                        },
                                                    Title = "New Product 3",
                                                    Text = "adipiscing elit fusce vel sapien elit in malesuada"
                                                }
                                        }
                                },
                        },
                    SaleCarousel = new Carousel
                        {
                            TargetId = "SaleCarousel",
                            Container = new Container<ProductSummary>
                                {
                                    GroupCount = 1,
                                    Items = new List<ProductSummary>
                                        {
                                            new ProductSummary
                                                {
                                                    Id = 1,
                                                    Image = new Image
                                                        {
                                                            Source = "Content/Images/products/product_2_small.jpg"
                                                        },
                                                    Link = new Link
                                                        {
                                                            LinkText = "View",
                                                            ActionName = "Product",
                                                            ControllerName = "Shop"
                                                        },
                                                    Title = "Sale Product 1",
                                                    Text = "elit fusce vel sapien elit in malesuada semper mi"
                                                },
                                            new ProductSummary
                                                {
                                                    Id = 2,
                                                    Image = new Image
                                                        {
                                                            Source = "Content/Images/products/product_3_small.jpg"
                                                        },
                                                    Link = new Link
                                                        {
                                                            LinkText = "View",
                                                            ActionName = "Product",
                                                            ControllerName = "Shop"
                                                        },
                                                    Title = "Sale Product 2",
                                                    Text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit"
                                                },
                                            new ProductSummary
                                                {
                                                    Id = 3,
                                                    Image = new Image
                                                        {
                                                            Source = "Content/Images/products/product_4_small.jpg"
                                                        },
                                                    Link = new Link
                                                        {
                                                            LinkText = "View",
                                                            ActionName = "Product",
                                                            ControllerName = "Shop"
                                                        },
                                                    Title = "Sale Product 3",
                                                    Text = "id sollicitudin urna fermentum ut fusce varius nisl ac"
                                                }
                                        }
                                },
                        },
                    FeaturedGallery = new Carousel
                        {
                            Title = "Featured Gallery",
                            TargetId = "FeaturedGallery",
                            IndicatorsVisible = true,
                            Container = new Container<ProductSummary>
                                {
                                    GroupCount = 3,
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
                                                            Source = "Content/Images/products/product_1_small.jpg"
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
                                                            Source = "Content/Images/products/product_2_small.jpg"
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
                                                            Source = "Content/Images/products/product_3_small.jpg"
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
                                                            Source = "Content/Images/products/product_4_small.jpg"
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
                                                            Source = "Content/Images/products/product_5_small.jpg"
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
                                                            Source = "Content/Images/products/product_6_small.jpg"
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
                        },
                    LatestGallery = new Carousel
                        {
                            Title = "Latest Gallery",
                            TargetId = "LatestGallery",
                            IndicatorsVisible = true,
                            Container = new Container<ProductSummary>
                                {
                                    GroupCount = 3,
                                    Items = new List<ProductSummary>
                                        {
                                            new ProductSummary
                                                {
                                                    Id = 1,
                                                    Title = "Latest Product 1",
                                                    IsNew = true,
                                                    Price = 1.23M,
                                                    Image = new Image
                                                        {
                                                            Source = "Content/Images/products/product_1_small.jpg"
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
                                                    Title = "Latest Product 2",
                                                    IsNew = true,
                                                    Price = 2.34M,
                                                    Image = new Image
                                                        {
                                                            Source = "Content/Images/products/product_2_small.jpg"
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
                                                    Title = "Latest Product 3",
                                                    IsNew = true,
                                                    Price = 3.45M,
                                                    Image = new Image
                                                        {
                                                            Source = "Content/Images/products/product_3_small.jpg"
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
                                                    Title = "Latest Product 4",
                                                    IsNew = true,
                                                    Price = 4.56M,
                                                    Image = new Image
                                                        {
                                                            Source = "Content/Images/products/product_4_small.jpg"
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
                                                    Title = "Latest Product 5",
                                                    IsNew = true,
                                                    Price = 5.67M,
                                                    Image = new Image
                                                        {
                                                            Source = "Content/Images/products/product_5_small.jpg"
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
                                                    Title = "Latest Product 6",
                                                    IsNew = true,
                                                    Price = 6.78M,
                                                    Image = new Image
                                                        {
                                                            Source = "Content/Images/products/product_6_small.jpg"
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
                        },
                    SaleGallery = new Carousel
                        {
                            Title = "Sale Gallery",
                            TargetId = "SaleGallery",
                            IndicatorsVisible = true,
                            Container = new Container<ProductSummary>
                                {
                                    GroupCount = 3,
                                    Items = new List<ProductSummary>
                                        {
                                            new ProductSummary
                                                {
                                                    Id = 1,
                                                    Title = "Sale Product 1",
                                                    Price = 2.34M,
                                                    DicountedPrice = 1.23M,
                                                    Image = new Image
                                                        {
                                                            Source = "Content/Images/products/product_1_small.jpg"
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
                                                    Title = "Sale Product 2",
                                                    Price = 3.45M,
                                                    DicountedPrice = 2.34M,
                                                    Image = new Image
                                                        {
                                                            Source = "Content/Images/products/product_2_small.jpg"
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
                                                    Title = "Sale Product 3",
                                                    Price = 4.56M,
                                                    DicountedPrice = 3.45M,
                                                    Image = new Image
                                                        {
                                                            Source = "Content/Images/products/product_3_small.jpg"
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
                                                    Title = "Sale Product 4",
                                                    Price = 5.67M,
                                                    DicountedPrice = 4.56M,
                                                    Image = new Image
                                                        {
                                                            Source = "Content/Images/products/product_4_small.jpg"
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
                                                    Title = "Sale Product 5",
                                                    Price = 6.78M,
                                                    DicountedPrice = 5.67M,
                                                    Image = new Image
                                                        {
                                                            Source = "Content/Images/products/product_5_small.jpg"
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
                                                    Title = "Sale Product 6",
                                                    Price = 7.89M,
                                                    DicountedPrice = 6.78M,
                                                    Image = new Image
                                                        {
                                                            Source = "Content/Images/products/product_6_small.jpg"
                                                        },
                                                    Link = new Link
                                                        {
                                                            LinkText = "View",
                                                            ActionName = "Product",
                                                            ControllerName = "Shop"
                                                        }
                                                },
                                        }
                                },
                        }
                };
            base.OnActionExecuting(filterContext);
        }
    }
}
using System;
using System.Linq;
using System.Web;

namespace Weblitz.Shop.Web.Models.View
{
    public class ShopFront : Page
    {
        public Carousel FeaturedProducts { get; set; }
        public Carousel NewProducts { get; set; }
        public Carousel SaleProducts { get; set; }
    }
}
using System.Linq;
using System.Web;

namespace Weblitz.Shop.Web.Models.View
{
    public class ShopFront : Page
    {
        public Carousel FeaturedCarousel { get; set; }
        public Carousel LatestCarousel { get; set; }
        public Carousel SaleCarousel { get; set; }
        public Gallery FeaturedGallery { get; set; }
        public Gallery LatestGallery { get; set; }
        public Gallery SaleGallery { get; set; }
    }
}
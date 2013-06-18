using System.Linq;
using System.Web;

namespace Weblitz.Shop.Web.Models.View
{
    public class ShopFront : Page
    {
        public Carousel FeaturedCarousel { get; set; }
        public Carousel LatestCarousel { get; set; }
        public Carousel SaleCarousel { get; set; }
        public Carousel FeaturedGallery { get; set; }
        public Carousel LatestGallery { get; set; }
        public Carousel SaleGallery { get; set; }
    }
}
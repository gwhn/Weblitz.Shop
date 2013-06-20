using System.Linq;
using System.Web;

namespace Weblitz.Shop.Web.Models.View
{
    public class HomePage : Page
    {
        public Carousel FeaturedMedia { get; set; }
        public Carousel LatestMedia { get; set; }
        public Carousel SaleMedia { get; set; }
        public Carousel FeaturedThumbnails { get; set; }
        public Carousel LatestThumbnails { get; set; }
        public Carousel SaleThumbnails { get; set; }
    }
}
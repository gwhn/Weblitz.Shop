using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.Web.Routing;
using Weblitz.Shop.Web.Controllers;
using Weblitz.Shop.Web.Models.View;

namespace Weblitz.Shop.Web.Filters
{
    public class SetupHomeSetupPageAttribute : SetupPageAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.Controller.ViewData.Model = new HomePage
                {
                    Title = "Weblitz Shop",
                    SectionId = base.SectionId,
                    FeaturedMedia = new Carousel
                        {
                            TargetId = "FeaturedMedia",
                            IndicatorsVisible = true,
                            Container = new Container<ProductSummary> {GroupCount = 1}
                        },
                    LatestMedia = new Carousel
                        {
                            TargetId = "LatestMedia",
                            Container = new Container<ProductSummary> {GroupCount = 1}
                        },
                    SaleMedia = new Carousel
                        {
                            TargetId = "SaleMedia",
                            Container = new Container<ProductSummary> {GroupCount = 1}
                        },
                    FeaturedThumbnails = new Carousel
                        {
                            Title = "Featured Gallery",
                            TargetId = "FeaturedThumbnails",
                            IndicatorsVisible = true,
                            Container = new Container<ProductSummary> {GroupCount = 6}
                        },
                    LatestThumbnails = new Carousel
                        {
                            Title = "Latest Gallery",
                            TargetId = "LatestThumbnails",
                            IndicatorsVisible = true,
                            Container = new Container<ProductSummary> {GroupCount = 6}
                        },
                    SaleThumbnails = new Carousel
                        {
                            Title = "Sale Gallery",
                            TargetId = "SaleThumbnails",
                            IndicatorsVisible = true,
                            Container = new Container<ProductSummary> {GroupCount = 6}
                        }
                };
            base.OnActionExecuting(filterContext);
        }
    }
}
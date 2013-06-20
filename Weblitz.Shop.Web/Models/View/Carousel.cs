namespace Weblitz.Shop.Web.Models.View
{
    public class Carousel : IContainable<ProductSummary>
    {
        public string TargetId { get; set; }
        public string Title { get; set; }
        public bool IndicatorsVisible { get; set; }
        public bool ControlsVisible { get; set; }
        public Container<ProductSummary> Container { get; set; }

        public Carousel()
        {
            Container = new Container<ProductSummary>();
        }
    }
}
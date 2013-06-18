namespace Weblitz.Shop.Web.Models.View
{
    public class ProductSummary
    {
        public int Id { get; set; }
        public Image Image { get; set; }
        public Link Link { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public decimal Price { get; set; }
        public decimal? DicountedPrice { get; set; }
        public bool IsNew { get; set; }
    }
}
namespace Weblitz.Shop.Web.Models.View
{
    public class CategoryPage : Page, IPageable
    {
        public CategorySidebar Sidebar { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
        public int ItemsPerPage { get; set; }
        public Link PageLink { get; set; }
        public int WindowSize { get; set; }
        public Container<ProductSummary> Container { get; set; }

        public CategoryPage()
        {
            Container = new Container<ProductSummary>();
        }
    }
}
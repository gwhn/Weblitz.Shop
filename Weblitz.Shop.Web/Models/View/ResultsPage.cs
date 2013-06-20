using System.Collections.Generic;

namespace Weblitz.Shop.Web.Models.View
{
    public class ResultsPage : Page, IListable<ProductSummary>
    {
        public string Query { get; set; }
        public Sidebar Sidebar { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
        public int ItemsPerPage { get; set; }
        public int[] PerPageOptions { get; set; }
        public Link PageLink { get; set; }
        public int WindowSize { get; set; }
        public ViewMode ViewMode { get; set; }
        public string SortBy { get; set; }
        public IDictionary<string, string> SortOptions { get; set; }
        public Container<ProductSummary> Container { get; set; }

        public ResultsPage()
        {
            Container = new Container<ProductSummary>();
        }
    }
}
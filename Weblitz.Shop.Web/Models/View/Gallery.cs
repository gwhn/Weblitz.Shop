using System.Collections.Generic;

namespace Weblitz.Shop.Web.Models.View
{
    public class Gallery : IPageable
    {
        public string Title { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
        public int ItemsPerPage { get; set; }
        public Link PageLink { get; set; }
        public IList<ProductSummary> Items { get; set; }

        public Gallery()
        {
            Items = new List<ProductSummary>();
        }
    }
}
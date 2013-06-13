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
        public IList<Item> Items { get; set; }

        public class Item
        {
            public Image Image { get; set; }
            public Link Link { get; set; }
            public string Title { get; set; }
            public decimal Price { get; set; }
            public decimal? DicountedPrice { get; set; }
            public bool IsNew { get; set; }
            public bool IsDiscounted { get; set; }
        }

        public Gallery()
        {
            Items = new List<Item>();
        }
    }
}
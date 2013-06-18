using System.Collections.Generic;

namespace Weblitz.Shop.Web.Models.View
{
    public class CategorySidebar
    {
        public string Name { get; set; }
        public IList<CategorySummary> Children { get; set; }

        public CategorySidebar()
        {
            Children = new List<CategorySummary>();
        }
    }
}
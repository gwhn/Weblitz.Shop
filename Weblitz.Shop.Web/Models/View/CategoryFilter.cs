using System.Collections.Generic;

namespace Weblitz.Shop.Web.Models.View
{
    public class CategoryFilter
    {
        public string Name { get; set; }
        public IList<CategorySummary> Children { get; set; }

        public CategoryFilter()
        {
            Children = new List<CategorySummary>();
        }
    }
}
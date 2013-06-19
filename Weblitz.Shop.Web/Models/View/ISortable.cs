using System.Collections.Generic;

namespace Weblitz.Shop.Web.Models.View
{
    public interface ISortable
    {
        string SortBy { get; set; }
        IDictionary<string, string> SortOptions { get; set; }
    }
}
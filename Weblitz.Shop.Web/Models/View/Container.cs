using System.Collections.Generic;

namespace Weblitz.Shop.Web.Models.View
{
    public class Container<T>
    {
        public int GroupCount { get; set; }
        public IList<T> Items { get; set; }
    }
}
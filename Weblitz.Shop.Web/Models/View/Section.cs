using System.Collections.Generic;

namespace Weblitz.Shop.Web.Models.View
{
    public class Section
    {
        public string Name { get; set; }
        public ICollection<Link> Links { get; set; }
    }
}
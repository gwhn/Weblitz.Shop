using System.Collections.Generic;

namespace Weblitz.Shop.Web.Models.View
{
    public class MenuItem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ActiveClass { get; set; }
        public ICollection<MenuItem> Children { get; set; }

        public MenuItem()
        {
            Children = new List<MenuItem>();
        }
    }
}
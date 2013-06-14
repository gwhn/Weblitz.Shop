using System.Collections.Generic;

namespace Weblitz.Shop.Web.Models.View
{
    public abstract class TrailPage : Page
    {
        public IList<Link> Breadcrumbs { get; set; }

        protected TrailPage()
        {
            Breadcrumbs = new List<Link>
                {
                    new Link
                        {
                            LinkText = "Home",
                            ActionName = "Index",
                            ControllerName = "Shop"
                        }
                };
        }
    }
}
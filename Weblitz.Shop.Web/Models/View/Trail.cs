using System;
using System.Collections.Generic;

namespace Weblitz.Shop.Web.Models.View
{
    public class Trail
    {
        public IList<Link> Breadcrumbs { get; set; }
        public Uri UrlReferer { get; set; }

        public Trail()
        {
            Breadcrumbs = new List<Link>();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace Weblitz.Shop.Web.Models.View
{
    public abstract class Page
    {
        public string Title { get; set; }
        public string SectionId { get; set; }
        public string CurrentYear { get; set; }
        public Trail Trail { get; set; }

        protected Page()
        {
            Title = "Weblitz Shop";
            CurrentYear = DateTime.Now.Year.ToString(CultureInfo.InvariantCulture);
        }
    }
}
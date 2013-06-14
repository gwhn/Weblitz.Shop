using System;
using System.Linq;
using System.Web;

namespace Weblitz.Shop.Web.Models.View
{
    public abstract class Page
    {
        public string Title { get; set; }
        public string SectionId { get; set; }
        public string CurrentYear { get; set; }
    }
}
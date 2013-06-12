using System.Web.Routing;

namespace Weblitz.Shop.Web.Models.View
{
    public class Link
    {
        public string LinkText { get; set; }
        public string ActionName { get; set; }
        public string ControllerName { get; set; }
        public object RouteValues { get; set; }
    }
}
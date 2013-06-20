using System.Web.Mvc;

namespace Weblitz.Shop.Web.Filters
{
    public abstract class SetupPageAttribute : ActionFilterAttribute
    {
        private string _sectionId;
        
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            _sectionId = string.Format("{0}_{1}",
                                       filterContext.RouteData.Values["Controller"],
                                       filterContext.RouteData.Values["Action"]);
            base.OnActionExecuting(filterContext);
        }

        protected string SectionId
        {
            get { return _sectionId; }
            set { _sectionId = value; }
        }        
    }
}
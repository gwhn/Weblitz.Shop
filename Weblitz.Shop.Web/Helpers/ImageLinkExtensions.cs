using System.Collections.Generic;
using System.Web;
using System.Web.Mvc;

namespace Weblitz.Shop.Web.Helpers
{
    public static class ImageLinkExtensions
    {
        /// <summary>
        /// Builds an HTML image link 
        /// </summary>
        /// <param name="helper">HTML helper</param>
        /// <param name="imageSrc">Image source</param>
        /// <param name="imageAlt">Image alternate text</param>
        /// <param name="imageHtmlAttributes">Other image HTML attributes</param>
        /// <param name="actionName">Action name</param>
        /// <param name="controllerName">Controller name</param>
        /// <param name="routeValues">Route Values</param>
        /// <param name="linkHtmlAttributes">Other link HTML attributes</param>
        /// <returns>HTML encoded string</returns>
        public static IHtmlString ImageLink(this HtmlHelper helper,
                                            string imageSrc,
                                            string imageAlt,
                                            object imageHtmlAttributes,
                                            string actionName,
                                            string controllerName,
                                            object routeValues,
                                            object linkHtmlAttributes)
        {
            // Build image tag
            var img = new TagBuilder("img");
            // Merge image attributes
            img.MergeAttribute("src", imageSrc);
            img.MergeAttribute("alt", imageAlt);
            img.MergeAttributes(imageHtmlAttributes as IDictionary<string, object>);
            // Build a tag
            var a = new TagBuilder("a");
            // Build action link
            var url = new UrlHelper(helper.ViewContext.RequestContext);
            var href = url.Action(actionName, controllerName, routeValues);
            // Merge link attributes
            a.MergeAttribute("href", href);
            a.MergeAttributes(linkHtmlAttributes as IDictionary<string, object>);
            // Embed image in link
            a.InnerHtml = img.ToString(TagRenderMode.SelfClosing);
            // Return HTML encoded string
            return new MvcHtmlString(a.ToString(TagRenderMode.Normal));
        }
    }
}
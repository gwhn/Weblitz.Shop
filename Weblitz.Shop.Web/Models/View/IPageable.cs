namespace Weblitz.Shop.Web.Models.View
{
    public interface IPageable
    {
        int CurrentPage { get; set; }
        int PageCount { get; set; }
        int ItemsPerPage { get; set; }
        Link PageLink { get; set; }
    }
}
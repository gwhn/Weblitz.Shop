namespace Weblitz.Shop.Web.Models.View
{
    public interface IListable<T> : IContainable<T>, IPageable, IViewable, ISortable
    {
    }
}
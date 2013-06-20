namespace Weblitz.Shop.Web.Models.View
{
    public interface IContainable<T>
    {
        Container<T> Container { get; set; }        
    }
}
namespace Weblitz.Shop.Web.Models.View
{
    public class Image
    {
        public string Source { get; set; }
        public string Width { get; set; }
        public string Height { get; set; }
        public string AltText { get; set; }
        public ImageAlignment Alignment { get; set; }

        public enum ImageAlignment
        {
            Left, Center, Right
        }

        public Image()
        {
            Alignment = ImageAlignment.Left;
        }
    }
}
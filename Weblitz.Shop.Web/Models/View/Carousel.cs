using System.Collections.Generic;

namespace Weblitz.Shop.Web.Models.View
{
    public class Carousel
    {
        public string TargetId { get; set; }
        public bool IndicatorsVisible { get; set; }
        public bool ControlsVisible { get; set; }
        public IList<Item> Items { get; set; }

        public class Item
        {
            public string Title { get; set; }
            public string Text { get; set; }
            public Link Link { get; set; }
            public Image Image { get; set; }
            public Alignment ImageAlignment { get; set; }

            public enum Alignment
            {
                Left, Right
            }

            public Item()
            {
                ImageAlignment = Alignment.Left;
            }
        }

        public Carousel()
        {
            Items = new List<Item>();
        }
    }
}
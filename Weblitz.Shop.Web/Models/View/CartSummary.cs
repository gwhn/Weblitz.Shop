using System;
using System.Collections.Generic;

namespace Weblitz.Shop.Web.Models.View
{
    public class CartSummary
    {
        public Decimal Total { get; set; }
        public ICollection<Item> Items { get; set; }
        public Decimal SubTotal { get; set; }
        public Decimal Discount { get; set; }
        public Decimal Tax { get; set; }

        public class Item
        {
            public string ImageUrl { get; set; }
            public string Name { get; set; }
            public int Quantity { get; set; }
            public decimal Cost { get; set; }
        }
        
        public CartSummary()
        {
            Items = new List<Item>();
        }
    }
}
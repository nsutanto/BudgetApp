using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ShoppingApp.Models
{
    public class ShoppingItem
    {
        public int Id { get; set; }

        public virtual ShoppingVendor ShoppingVendor { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set; }

        public string Name { get; set; }

        public int Quantity { get; set; }
    }
}
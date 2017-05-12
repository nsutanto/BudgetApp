using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace ShoppingApp.Models
{
    public class ShoppingVendor
    {
        public int Id { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set;}

        public virtual ICollection<ShoppingItem> ShoppingItems { get; set; }

        public string Name { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BudgetApp.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        public virtual ApplicationUser ApplicationUser { get; set;}

        public string Name { get; set; }

        public int Price { get; set; }

        public string Note { get; set; }
    }
}
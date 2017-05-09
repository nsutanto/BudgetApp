using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BudgetApp.Models
{
    public class Transaction
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public int Price { get; set; }
    }
}
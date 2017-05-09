using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BudgetApp.Models
{
    public class UserDetail
    {
        public int UserDetailId { get; set; }

        public string Name { get; set; }

        public ICollection<Transaction> Transactions { get; set; }
    }
}
using System.Collections.Generic;

namespace SimpleExpenseTracker.Model
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public virtual List<Expense> Expenses { get; set; }
    }
}

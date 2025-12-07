using System;

namespace SimpleExpenseTracker.Model
{
    public class Expense
    {
        public int ExpenseId { get; set; }
        public string Title { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
    }
}

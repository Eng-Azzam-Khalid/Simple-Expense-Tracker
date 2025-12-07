using System.Data.Entity;
using SimpleExpenseTracker.Model;

namespace SimpleExpenseTracker.DAL
{
    public class ExpenseTrackerContext : DbContext
    {
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Category> Categories { get; set; }

        public ExpenseTrackerContext() : base("ExpenseTrackerDB")
        {
        }
    }
}

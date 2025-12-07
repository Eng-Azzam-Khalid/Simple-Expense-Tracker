using System.Data.Entity.Migrations;
using SimpleExpenseTracker.DAL;
using SimpleExpenseTracker.Model;

internal sealed class Configuration : DbMigrationsConfiguration<ExpenseTrackerContext>
{
    public Configuration()
    {
        AutomaticMigrationsEnabled = false;
    }

    protected override void Seed(ExpenseTrackerContext context)
    {
        context.Categories.AddOrUpdate(
            c => c.Name,
            new Category { Name = "Food" },
            new Category { Name = "Transport" },
            new Category { Name = "Entertainment" },
            new Category { Name = "Utilities" }
        );
        context.SaveChanges();
    }
}

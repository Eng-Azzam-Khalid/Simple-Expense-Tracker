using System.Data.Entity.Migrations;

public partial class InitialCreate : DbMigration
{
    public override void Up()
    {
        CreateTable(
            "dbo.Categories",
            c => new
            {
                CategoryId = c.Int(nullable: false, identity: true),
                Name = c.String(),
            })
        .PrimaryKey(t => t.CategoryId);

        CreateTable(
            "dbo.Expenses",
            c => new
            {
                ExpenseId = c.Int(nullable: false, identity: true),
                Title = c.String(),
                Amount = c.Decimal(nullable: false, precision: 18, scale: 2),
                Date = c.DateTime(nullable: false),
                CategoryId = c.Int(nullable: false),
            })
        .PrimaryKey(t => t.ExpenseId)
        .ForeignKey("dbo.Categories", t => t.CategoryId, cascadeDelete: true)
        .Index(t => t.CategoryId);
    }

    public override void Down()
    {
        DropForeignKey("dbo.Expenses", "CategoryId", "dbo.Categories");
        DropIndex("dbo.Expenses", new[] { "CategoryId" });
        DropTable("dbo.Expenses");
        DropTable("dbo.Categories");
    }
}

namespace Sportscasters_final.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateCustomer : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customer", "LastPurchase", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customer", "LastPurchase", c => c.DateTime(nullable: false));
        }
    }
}

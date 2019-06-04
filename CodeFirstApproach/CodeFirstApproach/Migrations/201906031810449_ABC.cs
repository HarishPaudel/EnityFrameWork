namespace CodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ABC : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.tblproducts", "price1", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            DropColumn("dbo.tblproducts", "price1");
        }
    }
}

namespace CodeFirstApproach.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.tblcategory",
                c => new
                    {
                        categoryid = c.Int(nullable: false, identity: true),
                        categoryname = c.String(),
                    })
                .PrimaryKey(t => t.categoryid);
            
            CreateTable(
                "dbo.tblproducts",
                c => new
                    {
                        productid = c.Int(nullable: false, identity: true),
                        productname = c.String(),
                        price = c.Decimal(nullable: false, precision: 18, scale: 2),
                        category_categoryid = c.Int(),
                    })
                .PrimaryKey(t => t.productid)
                .ForeignKey("dbo.tblcategory", t => t.category_categoryid)
                .Index(t => t.category_categoryid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.tblproducts", "category_categoryid", "dbo.tblcategory");
            DropIndex("dbo.tblproducts", new[] { "category_categoryid" });
            DropTable("dbo.tblproducts");
            DropTable("dbo.tblcategory");
        }
    }
}

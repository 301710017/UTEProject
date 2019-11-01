namespace UTETickets.BusinessEntities.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customer",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30, unicode: false, storeType: "nvarchar"),
                        LastName = c.String(nullable: false, maxLength: 30, unicode: false, storeType: "nvarchar"),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Sale",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerID = c.Int(nullable: false),
                        TransactionID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customer", t => t.CustomerID, cascadeDelete: true)
                .ForeignKey("dbo.Paypal", t => t.TransactionID, cascadeDelete: true)
                //.Index(t => t.CustomerID)
                //.Index(t => t.TransactionID)
                ;
            Sql("CREATE index `IX_CustomerID` on `Sale` (`CustomerID` DESC)");
            Sql("CREATE index `IX_TransactionID` on `Sale` (`TransactionID` DESC)");


            CreateTable(
                "dbo.Paypal",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Ticket",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        SaleID = c.Int(nullable: false),
                        RouteID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Route", t => t.RouteID, cascadeDelete: true)
                .ForeignKey("dbo.Sale", t => t.SaleID, cascadeDelete: true)
                //.Index(t => t.RouteID)
                //.Index(t => t.SaleID)
                ;
            Sql("CREATE index `IX_RouteID` on `Ticket` (`RouteID` DESC)");
            Sql("CREATE index `IX_SaleID` on `Ticket` (`SaleID` DESC)");

            CreateTable(
                "dbo.Route",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        route = c.String(nullable: false, maxLength: 30, unicode: false, storeType: "nvarchar"),
                        Cost = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Manager",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 30, unicode: false, storeType: "nvarchar"),
                        LastName = c.String(nullable: false, maxLength: 30, unicode: false, storeType: "nvarchar"),
                        RollID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Roll", t => t.RollID, cascadeDelete: true)
                //.Index(t => t.RollID)
                ;
                Sql("CREATE index `IX_RollID` on `Manager` (`RollID` DESC)");

            CreateTable(
                "dbo.Roll",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Category = c.String(nullable: false, unicode: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Manager", "RollID", "dbo.Roll");
            DropForeignKey("dbo.Ticket", "SaleID", "dbo.Sale");
            DropForeignKey("dbo.Ticket", "RouteID", "dbo.Route");
            DropForeignKey("dbo.Sale", "TransactionID", "dbo.Paypal");
            DropForeignKey("dbo.Sale", "CustomerID", "dbo.Customer");
            DropIndex("dbo.Manager", new[] { "RollID" });
            DropIndex("dbo.Ticket", new[] { "SaleID" });
            DropIndex("dbo.Ticket", new[] { "RouteID" });
            DropIndex("dbo.Sale", new[] { "TransactionID" });
            DropIndex("dbo.Sale", new[] { "CustomerID" });
            DropTable("dbo.Roll");
            DropTable("dbo.Manager");
            DropTable("dbo.Route");
            DropTable("dbo.Ticket");
            DropTable("dbo.Paypal");
            DropTable("dbo.Sale");
            DropTable("dbo.Customer");
        }
    }
}

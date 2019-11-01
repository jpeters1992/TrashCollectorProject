namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedMoreCustomerModels : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StreetAddress = c.String(),
                        CityName = c.String(),
                        ZipCode = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.PickUps",
                c => new
                    {
                        ZipCode = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.ZipCode);
            
            AddColumn("dbo.Customers", "WeeklyPickUpDay", c => c.Int(nullable: false));
            AddColumn("dbo.Customers", "PickupCharge", c => c.Double(nullable: false));
            AddColumn("dbo.Customers", "Balance", c => c.Double());
            AddColumn("dbo.Customers", "MonthlyCharge", c => c.Double());
            AddColumn("dbo.Customers", "PickupConfirmed", c => c.Boolean());
            AddColumn("dbo.Customers", "ServiceStartDate", c => c.DateTime());
            AddColumn("dbo.Customers", "ServiceEndDate", c => c.DateTime());
            AddColumn("dbo.Customers", "ExtraPickUpDate", c => c.DateTime());
            DropColumn("dbo.Customers", "OutstandingBalance");
            DropColumn("dbo.Employees", "FirstName");
            DropColumn("dbo.Employees", "LastName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Employees", "LastName", c => c.String());
            AddColumn("dbo.Employees", "FirstName", c => c.String());
            AddColumn("dbo.Customers", "OutstandingBalance", c => c.Double(nullable: false));
            DropColumn("dbo.Customers", "ExtraPickUpDate");
            DropColumn("dbo.Customers", "ServiceEndDate");
            DropColumn("dbo.Customers", "ServiceStartDate");
            DropColumn("dbo.Customers", "PickupConfirmed");
            DropColumn("dbo.Customers", "MonthlyCharge");
            DropColumn("dbo.Customers", "Balance");
            DropColumn("dbo.Customers", "PickupCharge");
            DropColumn("dbo.Customers", "WeeklyPickUpDay");
            DropTable("dbo.PickUps");
            DropTable("dbo.Addresses");
        }
    }
}

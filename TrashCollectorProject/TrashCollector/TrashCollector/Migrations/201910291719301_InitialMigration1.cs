namespace TrashCollector.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "TestProperty", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "TestProperty");
        }
    }
}

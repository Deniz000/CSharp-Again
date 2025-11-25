namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        //update yaparsan bu
        public override void Up()
        {
            AddColumn("dbo.Customers", "CustomerStatus", c => c.Boolean(nullable: false));
        }
        
        //işlemi geri alırsan bu
        public override void Down()
        {
            DropColumn("dbo.Customers", "CustomerStatus");
        }
    }
}

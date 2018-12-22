namespace DzReplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PhoneForPerson : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.People", "Phone", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.People", "Phone");
        }
    }
}

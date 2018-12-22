namespace DzReplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPersonForBook : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        Pages = c.Int(nullable: false),
                        person_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.People", t => t.person_Id)
                .Index(t => t.person_Id);
            
            CreateTable(
                "dbo.People",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FirestName = c.String(),
                        MiddleName = c.String(),
                        LastName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "person_Id", "dbo.People");
            DropIndex("dbo.Books", new[] { "person_Id" });
            DropTable("dbo.People");
            DropTable("dbo.Books");
        }
    }
}

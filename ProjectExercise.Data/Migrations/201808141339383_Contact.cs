namespace ProjectExercise.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Contact : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contact",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 255),
                        LastName = c.String(maxLength: 255),
                        PhoneNumber = c.Long(),
                        EmailId = c.String(maxLength: 255),
                        Status = c.String(maxLength: 50),
                        ModifiedBy = c.Int(),
                        Modified = c.DateTime(),
                        CreatedBy = c.Int(),
                        Created = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.ProjectUser",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(maxLength: 255),
                        LastName = c.String(maxLength: 255),
                        UserName = c.String(maxLength: 255),
                        Password = c.String(maxLength: 50),
                        Status = c.String(maxLength: 50),
                        ModifiedBy = c.Int(),
                        Modified = c.DateTime(),
                        CreatedBy = c.Int(),
                        Created = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ProjectUser");
            DropTable("dbo.Contact");
        }
    }
}

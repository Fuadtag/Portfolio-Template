namespace _20191910WeekendTask.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ModelsAdded : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Awards",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Contacts",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Adress = c.String(),
                        Phone = c.String(),
                        Email = c.String(),
                        Description = c.String(),
                        LinkedinLink = c.String(),
                        FacebookLink = c.String(),
                        GithubLink = c.String(),
                        TwitterLink = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Educations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        University = c.String(),
                        Degree = c.String(),
                        Description = c.String(),
                        GPA = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Experiences",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Position = c.String(),
                        Company = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Interests",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Description = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Skills",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Skills");
            DropTable("dbo.Interests");
            DropTable("dbo.Experiences");
            DropTable("dbo.Educations");
            DropTable("dbo.Contacts");
            DropTable("dbo.Awards");
        }
    }
}

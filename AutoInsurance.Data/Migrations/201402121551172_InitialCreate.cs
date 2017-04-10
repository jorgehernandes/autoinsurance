namespace AutoInsurance.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Insured",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Age = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Car",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Model = c.String(),
                        Manufacturer = c.String(),
                        Year = c.Int(nullable: false),
                        Photo = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Proposal",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Value = c.Int(nullable: false),
                        Car_Id = c.Int(),
                        Insured_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Car", t => t.Car_Id)
                .ForeignKey("dbo.Insured", t => t.Insured_Id)
                .Index(t => t.Car_Id)
                .Index(t => t.Insured_Id);
            
        }
        
        public override void Down()
        {
            DropIndex("dbo.Proposal", new[] { "Insured_Id" });
            DropIndex("dbo.Proposal", new[] { "Car_Id" });
            DropForeignKey("dbo.Proposal", "Insured_Id", "dbo.Insured");
            DropForeignKey("dbo.Proposal", "Car_Id", "dbo.Car");
            DropTable("dbo.Proposal");
            DropTable("dbo.Car");
            DropTable("dbo.Insured");
        }
    }
}

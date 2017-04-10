namespace AutoInsurance.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AlterTableInsured : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Insured", "Rg", c => c.String());
            AddColumn("dbo.Insured", "Cpf", c => c.String());
            AddColumn("dbo.Insured", "Gender", c => c.String());
            AlterColumn("dbo.Proposal", "Value", c => c.Decimal(nullable: false, precision: 18, scale: 2));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Proposal", "Value", c => c.Int(nullable: false));
            DropColumn("dbo.Insured", "Gender");
            DropColumn("dbo.Insured", "Cpf");
            DropColumn("dbo.Insured", "Rg");
        }
    }
}

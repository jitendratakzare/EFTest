namespace SampleEFCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addstate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.States",
                c => new
                    {
                        StateId = c.Long(nullable: false, identity: true),
                        StateName = c.String(),
                        Country_CountryId = c.Long(),
                    })
                .PrimaryKey(t => t.StateId)
                .ForeignKey("dbo.Countries", t => t.Country_CountryId)
                .Index(t => t.Country_CountryId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.States", "Country_CountryId", "dbo.Countries");
            DropIndex("dbo.States", new[] { "Country_CountryId" });
            DropTable("dbo.States");
        }
    }
}

namespace Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NowaTabelaskierowanie : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.skierowanies",
                c => new
                    {
                        SkierowanieId = c.Int(nullable: false, identity: true),
                        Lekarz = c.String(nullable: false),
                        Pacjent = c.String(nullable: false),
                        Gdzie = c.String(nullable: false),
                        DataWystawnienia = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.SkierowanieId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.skierowanies");
        }
    }
}

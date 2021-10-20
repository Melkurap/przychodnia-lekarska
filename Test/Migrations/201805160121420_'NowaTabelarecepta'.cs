namespace Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NowaTabelarecepta : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.receptas",
                c => new
                    {
                        receptaId = c.Int(nullable: false, identity: true),
                        Pacjent = c.String(nullable: false),
                        NazwaLeku = c.String(nullable: false),
                        IloscOpakowanOrazTalbetek = c.String(nullable: false),
                        WaznoscRecepty = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.receptaId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.receptas");
        }
    }
}

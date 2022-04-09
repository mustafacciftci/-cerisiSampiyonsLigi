namespace İcerisiSampiyonsLigi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class uc1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "Point", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teams", "Point");
        }
    }
}

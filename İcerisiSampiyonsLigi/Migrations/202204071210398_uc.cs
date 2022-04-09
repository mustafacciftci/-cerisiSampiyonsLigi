namespace İcerisiSampiyonsLigi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class uc : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Players", "Mevkii", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Players", "Mevkii", c => c.String());
        }
    }
}

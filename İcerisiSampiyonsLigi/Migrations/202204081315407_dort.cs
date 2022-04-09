namespace İcerisiSampiyonsLigi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dort : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "ResimFutbolcu", c => c.String());
            AddColumn("dbo.Teams", "Amblem", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teams", "Amblem");
            DropColumn("dbo.Teams", "ResimFutbolcu");
        }
    }
}

namespace İcerisiSampiyonsLigi.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class dort1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Players", "Resim", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Players", "Resim");
        }
    }
}

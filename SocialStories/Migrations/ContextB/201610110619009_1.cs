namespace SocialStories.Migrations.ContextB
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class _1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PostStoryMode",
                c => new
                    {
                        PostStoryModeID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        MetaTags = c.String(),
                        Content = c.String(),
                        ParentID = c.Int(nullable: false),
                        MyProperty = c.Int(nullable: false),
                        CreatedByUserID = c.Int(nullable: false),
                        ResponseID = c.Int(nullable: false),
                        EmotionID = c.Int(nullable: false),
                        RevisionHistoryID = c.Int(nullable: false),
                        CreatedOn = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PostStoryModeID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.PostStoryMode");
        }
    }
}

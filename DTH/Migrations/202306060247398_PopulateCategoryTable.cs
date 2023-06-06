namespace DTH.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateCategoryTable : DbMigration
    {
        public override void Up()
        {
            Sql("INSER INTO CATEGORIES(ID,NAME) VALUES(1,'Development')");
            Sql("INSER INTO CATEGORIES(ID,NAME) VALUES(2,'Business')");
            Sql("INSER INTO CATEGORIES(ID,NAME) VALUES(1,'Marketing')");

        }
        
        public override void Down()
        {
        }
    }
}

namespace _13_RestaurantRater.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedRestaurantOwner : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Restaurants", "Owner", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Restaurants", "Owner");
        }
    }
}

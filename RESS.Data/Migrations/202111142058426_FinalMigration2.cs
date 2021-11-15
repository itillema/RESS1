namespace RESS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FinalMigration2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.CapitalizationRateAnalysis", "PropAddress", c => c.String());
            AddColumn("dbo.CapitalizationRateAnalysis", "RentalIncome", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.CapitalizationRateAnalysis", "PropMarketValue", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.CapitalizationRateAnalysis", "PropPurchasePrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.CapitalizationRateAnalysis", "PropOwnedDuration", c => c.Time(nullable: false, precision: 7));
            AddColumn("dbo.FourSquareAnalysis", "PropAddress", c => c.String());
            AddColumn("dbo.FourSquareAnalysis", "RentalIncome", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.NetOperatingIncome", "PropAddress", c => c.String());
            AddColumn("dbo.NetOperatingIncome", "RentalIncome", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AlterColumn("dbo.Property", "OwnedDuration", c => c.Time(nullable: true, precision: 7));
            DropColumn("dbo.CapitalizationRateAnalysis", "Address");
            DropColumn("dbo.CapitalizationRateAnalysis", "MarketRentValue");
            DropColumn("dbo.CapitalizationRateAnalysis", "MarketValue");
            DropColumn("dbo.CapitalizationRateAnalysis", "PurchasePrice");
            DropColumn("dbo.CapitalizationRateAnalysis", "OwnedDuration");
            DropColumn("dbo.Property", "OwnerFirstName");
            DropColumn("dbo.Property", "OwnerLastName");
            DropColumn("dbo.FourSquareAnalysis", "Address");
            DropColumn("dbo.FourSquareAnalysis", "MarketRentValue");
            DropColumn("dbo.NetOperatingIncome", "Address");
            DropColumn("dbo.NetOperatingIncome", "MarketRentValue");
        }
        
        public override void Down()
        {
            AddColumn("dbo.NetOperatingIncome", "MarketRentValue", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.NetOperatingIncome", "Address", c => c.String());
            AddColumn("dbo.FourSquareAnalysis", "MarketRentValue", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.FourSquareAnalysis", "Address", c => c.String());
            AddColumn("dbo.Property", "OwnerLastName", c => c.String());
            AddColumn("dbo.Property", "OwnerFirstName", c => c.String());
            AddColumn("dbo.CapitalizationRateAnalysis", "OwnedDuration", c => c.Time(nullable: true, precision: 7));
            AddColumn("dbo.CapitalizationRateAnalysis", "PurchasePrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.CapitalizationRateAnalysis", "MarketValue", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.CapitalizationRateAnalysis", "MarketRentValue", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.CapitalizationRateAnalysis", "Address", c => c.String());
            AlterColumn("dbo.Property", "OwnedDuration", c => c.Time(precision: 7));
            DropColumn("dbo.NetOperatingIncome", "RentalIncome");
            DropColumn("dbo.NetOperatingIncome", "PropAddress");
            DropColumn("dbo.FourSquareAnalysis", "RentalIncome");
            DropColumn("dbo.FourSquareAnalysis", "PropAddress");
            DropColumn("dbo.CapitalizationRateAnalysis", "PropOwnedDuration");
            DropColumn("dbo.CapitalizationRateAnalysis", "PropPurchasePrice");
            DropColumn("dbo.CapitalizationRateAnalysis", "PropMarketValue");
            DropColumn("dbo.CapitalizationRateAnalysis", "RentalIncome");
            DropColumn("dbo.CapitalizationRateAnalysis", "PropAddress");
        }
    }
}

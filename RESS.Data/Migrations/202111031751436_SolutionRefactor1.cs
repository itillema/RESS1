namespace RESS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SolutionRefactor1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CapitalizationRateAnalysis",
                c => new
                    {
                        CapitalizationRateAnalysisId = c.Int(nullable: false, identity: true),
                        CapRateRunDate = c.DateTime(nullable: false),
                        PropertyId = c.Int(nullable: false),
                        Address = c.String(),
                        MarketRentValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MarketValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OwnerId = c.Int(nullable: false),
                        PurchasePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        OwnedDuration = c.Time(nullable: false, precision: 7),
                        MonthlyLaundryIncome = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MonthlyMiscIncome = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalMonthlyIncome = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MonthlyMortgageExpense = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MonthlyRentalInsuranceExpense = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MonthlyUtilityExpense = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MonthlyHoaExpense = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MonthlyPropertyServiceExpense = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MonthlyVacancyExpense = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MonthlyRepairExpense = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MonthlyManagementExpense = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalMonthlyPropertyExpenses = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AnnualNetOperatingIncome = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AnnualRentIncreasePercent = c.Single(nullable: false),
                        CurrentCapitalizationRate = c.Single(nullable: false),
                        EstFiveYearCapitalizationRate = c.Single(nullable: false),
                        EstFifteenYearCapitalizationRate = c.Single(nullable: false),
                        EstThirtyYearCapitalizationRate = c.Single(nullable: false),
                        OwnedDurationCapitalizationRate = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.CapitalizationRateAnalysisId)
                .ForeignKey("dbo.Owner", t => t.OwnerId, cascadeDelete: true)
                .ForeignKey("dbo.Property", t => t.PropertyId, cascadeDelete: true)
                .Index(t => t.PropertyId)
                .Index(t => t.OwnerId);
            
            CreateTable(
                "dbo.Owner",
                c => new
                    {
                        OwnerId = c.Int(nullable: false, identity: true),
                        OwnerFirstName = c.String(),
                        OwnerLastName = c.String(),
                        MobileNo = c.String(),
                        Email = c.String(),
                        PurchaseDate = c.DateTime(nullable: false),
                        OwnedDuration = c.Time(nullable: false, precision: 7),
                        PurchasePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        DownPayment = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MortgageAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PropertyId = c.Int(nullable: false),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.OwnerId)
                //.ForeignKey("dbo.Property", t => t.PropertyId, cascadeDelete: true)
                .Index(t => t.PropertyId);
            
            CreateTable(
                "dbo.Property",
                c => new
                    {
                        PropertyId = c.Int(nullable: false, identity: true),
                        Address = c.String(nullable: false),
                        City = c.String(nullable: false),
                        State = c.Int(nullable: false),
                        Zip = c.String(nullable: false),
                        Beds = c.Int(nullable: false),
                        Baths = c.Decimal(nullable: false, precision: 18, scale: 2),
                        SquareFeet = c.Int(nullable: false),
                        HomeType = c.Int(nullable: false),
                        YearBuilt = c.Int(nullable: false),
                        Heating = c.Int(nullable: false),
                        Cooling = c.Int(nullable: false),
                        AvailableParking = c.Boolean(nullable: false),
                        ParkingType = c.Int(nullable: false),
                        LotSize = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Basement = c.Boolean(nullable: false),
                        Flooring = c.Int(nullable: false),
                        Roofing = c.Int(nullable: false),
                        ConstructionMaterials = c.Int(nullable: false),
                        Neighborhood = c.String(nullable: false),
                        Parcel = c.Int(nullable: false),
                        MarketValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MarketRentValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ThirdyDayChange = c.Single(),
                        PurchaseDate = c.DateTime(),
                        OwnedDuration = c.Time(precision: 7),
                        PurchasePrice = c.Decimal(precision: 18, scale: 2),
                        DownPayment = c.Decimal(precision: 18, scale: 2),
                        MortgageAmount = c.Decimal(precision: 18, scale: 2),
                        OwnerId = c.Int(nullable: false),
                        TenantId = c.Int(nullable: false),
                        Owner_OwnerId = c.Int(),
                    })
                .PrimaryKey(t => t.PropertyId)
                //.ForeignKey("dbo.Owner", t => t.OwnerId, cascadeDelete: true)
                .ForeignKey("dbo.Tenant", t => t.TenantId, cascadeDelete: true)
                .ForeignKey("dbo.Owner", t => t.Owner_OwnerId)
                .Index(t => t.OwnerId)
                .Index(t => t.TenantId)
                .Index(t => t.Owner_OwnerId);
            
            CreateTable(
                "dbo.Tenant",
                c => new
                    {
                        TenantId = c.Int(nullable: false, identity: true),
                        TenantFirstName = c.String(),
                        TenantLastName = c.String(),
                        MobileNo = c.String(),
                        Email = c.String(),
                        LeaseStart = c.DateTime(nullable: false),
                        LeaseEnd = c.DateTime(nullable: false),
                        LeaseDuration = c.Time(nullable: false, precision: 7),
                        SecurityDeposit = c.Decimal(nullable: false, precision: 18, scale: 2),
                        RentAmount = c.Decimal(nullable: false, precision: 18, scale: 2),
                        PropertyId = c.Int(nullable: false),
                        Address = c.String(),
                        Property_PropertyId = c.Int(),
                    })
                .PrimaryKey(t => t.TenantId)
                //.ForeignKey("dbo.Property", t => t.PropertyId, cascadeDelete: true)
                .ForeignKey("dbo.Property", t => t.Property_PropertyId)
                .Index(t => t.PropertyId)
                .Index(t => t.Property_PropertyId);
            
            CreateTable(
                "dbo.FourSquareAnalysis",
                c => new
                    {
                        FourSquareAnalysisId = c.Int(nullable: false, identity: true),
                        FourSquareDateRan = c.DateTime(nullable: false),
                        PropertyId = c.Int(nullable: false),
                        Address = c.String(),
                        MarketRentValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MonthlyLaundryIncome = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MonthlyMiscIncome = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalMonthlyIncome = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MonthlyMortgageExpense = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MonthlyRentalInsuranceExpense = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MonthlyTaxExpense = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MonthlyUtilityExpense = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MonthlyHoaExpense = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MonthlyPropertyServiceExpense = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MonthlyVacancyExpense = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MonthlyRepairExpense = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MonthlyManagementExpense = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalMonthlyPropertyExpenses = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalMonthlyCashFlow = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EstDownPayment = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EstClosingCost = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EstRehabBudget = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EstTotalInvestment = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EstAnnaulCashFlow = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalCtcRoi = c.Single(nullable: false),
                        InvestmentRisk = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FourSquareAnalysisId)
                .ForeignKey("dbo.Property", t => t.PropertyId, cascadeDelete: true)
                .Index(t => t.PropertyId);
            
            CreateTable(
                "dbo.NetOperatingIncome",
                c => new
                    {
                        NetOperatingIncomeId = c.Int(nullable: false, identity: true),
                        NOIRundate = c.DateTime(nullable: false),
                        PropertyId = c.Int(nullable: false),
                        Address = c.String(),
                        MarketRentValue = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MonthlyLaundryIncome = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MonthlyMiscIncome = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalMonthlyIncome = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MonthlyMortgageExpense = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MonthlyRentalInsuranceExpense = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MonthlyUtilityExpense = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MonthlyHoaExpense = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MonthlyPropertyServiceExpense = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MonthlyVacancyExpense = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MonthlyRepairExpense = c.Decimal(nullable: false, precision: 18, scale: 2),
                        MonthlyManagementExpense = c.Decimal(nullable: false, precision: 18, scale: 2),
                        TotalMonthlyPropertyExpenses = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AnnualNetOperatingIncome = c.Decimal(nullable: false, precision: 18, scale: 2),
                        AnnualRentIncreasePercent = c.Single(nullable: false),
                        FiveYearNoi = c.Decimal(nullable: false, precision: 18, scale: 2),
                        FifteenYearNoi = c.Decimal(nullable: false, precision: 18, scale: 2),
                        ThirtyYearNoi = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.NetOperatingIncomeId)
                .ForeignKey("dbo.Property", t => t.PropertyId, cascadeDelete: true)
                .Index(t => t.PropertyId);
            
            CreateTable(
                "dbo.IdentityRole",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserRole",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(),
                        IdentityRole_Id = c.String(maxLength: 128),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.IdentityRole", t => t.IdentityRole_Id)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .Index(t => t.IdentityRole_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.ApplicationUser",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.IdentityUserClaim",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
            CreateTable(
                "dbo.IdentityUserLogin",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        LoginProvider = c.String(),
                        ProviderKey = c.String(),
                        ApplicationUser_Id = c.String(maxLength: 128),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.ApplicationUser", t => t.ApplicationUser_Id)
                .Index(t => t.ApplicationUser_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.IdentityUserRole", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserLogin", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserClaim", "ApplicationUser_Id", "dbo.ApplicationUser");
            DropForeignKey("dbo.IdentityUserRole", "IdentityRole_Id", "dbo.IdentityRole");
            DropForeignKey("dbo.NetOperatingIncome", "PropertyId", "dbo.Property");
            DropForeignKey("dbo.FourSquareAnalysis", "PropertyId", "dbo.Property");
            DropForeignKey("dbo.CapitalizationRateAnalysis", "PropertyId", "dbo.Property");
            DropForeignKey("dbo.CapitalizationRateAnalysis", "OwnerId", "dbo.Owner");
            DropForeignKey("dbo.Owner", "PropertyId", "dbo.Property");
            DropForeignKey("dbo.Property", "Owner_OwnerId", "dbo.Owner");
            DropForeignKey("dbo.Tenant", "Property_PropertyId", "dbo.Property");
            DropForeignKey("dbo.Property", "TenantId", "dbo.Tenant");
            DropForeignKey("dbo.Tenant", "PropertyId", "dbo.Property");
            DropForeignKey("dbo.Property", "OwnerId", "dbo.Owner");
            DropIndex("dbo.IdentityUserLogin", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserClaim", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserRole", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserRole", new[] { "IdentityRole_Id" });
            DropIndex("dbo.NetOperatingIncome", new[] { "PropertyId" });
            DropIndex("dbo.FourSquareAnalysis", new[] { "PropertyId" });
            DropIndex("dbo.Tenant", new[] { "Property_PropertyId" });
            DropIndex("dbo.Tenant", new[] { "PropertyId" });
            DropIndex("dbo.Property", new[] { "Owner_OwnerId" });
            DropIndex("dbo.Property", new[] { "TenantId" });
            DropIndex("dbo.Property", new[] { "OwnerId" });
            DropIndex("dbo.Owner", new[] { "PropertyId" });
            DropIndex("dbo.CapitalizationRateAnalysis", new[] { "OwnerId" });
            DropIndex("dbo.CapitalizationRateAnalysis", new[] { "PropertyId" });
            DropTable("dbo.IdentityUserLogin");
            DropTable("dbo.IdentityUserClaim");
            DropTable("dbo.ApplicationUser");
            DropTable("dbo.IdentityUserRole");
            DropTable("dbo.IdentityRole");
            DropTable("dbo.NetOperatingIncome");
            DropTable("dbo.FourSquareAnalysis");
            DropTable("dbo.Tenant");
            DropTable("dbo.Property");
            DropTable("dbo.Owner");
            DropTable("dbo.CapitalizationRateAnalysis");
        }
    }
}

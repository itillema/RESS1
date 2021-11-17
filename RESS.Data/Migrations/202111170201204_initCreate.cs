namespace RESS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initCreate : DbMigration
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
                        OwnerId = c.Int(nullable: false),
                        RentalIncome = c.Decimal(nullable: false, precision: 18, scale: 2),
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
                        PropPurchasePrice = c.Decimal(nullable: false, precision: 18, scale: 2),
                        CurrentCapitalizationRate = c.Single(nullable: false),
                        EstFiveYearCapitalizationRate = c.Single(nullable: false),
                        EstFifteenYearCapitalizationRate = c.Single(nullable: false),
                        EstThirtyYearCapitalizationRate = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.CapitalizationRateAnalysisId);
            
            CreateTable(
                "dbo.FourSquareAnalysis",
                c => new
                    {
                        FourSquareAnalysisId = c.Int(nullable: false, identity: true),
                        FourSquareDateRan = c.DateTime(nullable: false),
                        PropertyId = c.Int(nullable: false),
                        RentalIncome = c.Decimal(nullable: false, precision: 18, scale: 2),
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
                    })
                .PrimaryKey(t => t.FourSquareAnalysisId);
            
            CreateTable(
                "dbo.NetOperatingIncome",
                c => new
                    {
                        NetOperatingIncomeId = c.Int(nullable: false, identity: true),
                        NOIRundate = c.DateTime(nullable: false),
                        PropertyId = c.Int(nullable: false),
                        RentalIncome = c.Decimal(nullable: false, precision: 18, scale: 2),
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
                .PrimaryKey(t => t.NetOperatingIncomeId);
            
            CreateTable(
                "dbo.Owner",
                c => new
                    {
                        OwnerId = c.Int(nullable: false, identity: true),
                        OwnerFirstName = c.String(),
                        OwnerLastName = c.String(),
                        MobileNo = c.String(),
                        Email = c.String(),
                        CapRate_CapitalizationRateAnalysisId = c.Int(),
                    })
                .PrimaryKey(t => t.OwnerId)
                .ForeignKey("dbo.CapitalizationRateAnalysis", t => t.CapRate_CapitalizationRateAnalysisId)
                .Index(t => t.CapRate_CapitalizationRateAnalysisId);
            
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
                        OwnedDuration = c.Time(nullable: false, precision: 7),
                        PurchasePrice = c.Decimal(precision: 18, scale: 2),
                        DownPayment = c.Decimal(precision: 18, scale: 2),
                        MortgageAmount = c.Decimal(precision: 18, scale: 2),
                        CapRate_CapitalizationRateAnalysisId = c.Int(),
                        FourSquare_FourSquareAnalysisId = c.Int(),
                        NOI_NetOperatingIncomeId = c.Int(),
                    })
                .PrimaryKey(t => t.PropertyId)
                .ForeignKey("dbo.CapitalizationRateAnalysis", t => t.CapRate_CapitalizationRateAnalysisId)
                .ForeignKey("dbo.FourSquareAnalysis", t => t.FourSquare_FourSquareAnalysisId)
                .ForeignKey("dbo.NetOperatingIncome", t => t.NOI_NetOperatingIncomeId)
                .Index(t => t.CapRate_CapitalizationRateAnalysisId)
                .Index(t => t.FourSquare_FourSquareAnalysisId)
                .Index(t => t.NOI_NetOperatingIncomeId);
            
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
                    })
                .PrimaryKey(t => t.TenantId);
            
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
            DropForeignKey("dbo.Property", "NOI_NetOperatingIncomeId", "dbo.NetOperatingIncome");
            DropForeignKey("dbo.Property", "FourSquare_FourSquareAnalysisId", "dbo.FourSquareAnalysis");
            DropForeignKey("dbo.Property", "CapRate_CapitalizationRateAnalysisId", "dbo.CapitalizationRateAnalysis");
            DropForeignKey("dbo.Owner", "CapRate_CapitalizationRateAnalysisId", "dbo.CapitalizationRateAnalysis");
            DropIndex("dbo.IdentityUserLogin", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserClaim", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserRole", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.IdentityUserRole", new[] { "IdentityRole_Id" });
            DropIndex("dbo.Property", new[] { "NOI_NetOperatingIncomeId" });
            DropIndex("dbo.Property", new[] { "FourSquare_FourSquareAnalysisId" });
            DropIndex("dbo.Property", new[] { "CapRate_CapitalizationRateAnalysisId" });
            DropIndex("dbo.Owner", new[] { "CapRate_CapitalizationRateAnalysisId" });
            DropTable("dbo.IdentityUserLogin");
            DropTable("dbo.IdentityUserClaim");
            DropTable("dbo.ApplicationUser");
            DropTable("dbo.Tenant");
            DropTable("dbo.IdentityUserRole");
            DropTable("dbo.IdentityRole");
            DropTable("dbo.Property");
            DropTable("dbo.Owner");
            DropTable("dbo.NetOperatingIncome");
            DropTable("dbo.FourSquareAnalysis");
            DropTable("dbo.CapitalizationRateAnalysis");
        }
    }
}

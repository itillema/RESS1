namespace RESS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigRefactor2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tenant", "PropertyId", "dbo.Property");
            DropIndex("dbo.Tenant", new[] { "PropertyId" });
            CreateTable(
                "dbo.TenantProperty",
                c => new
                    {
                        Tenant_TenantId = c.Int(nullable: false),
                        Property_PropertyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Tenant_TenantId, t.Property_PropertyId })
                .ForeignKey("dbo.Tenant", t => t.Tenant_TenantId, cascadeDelete: true)
                .ForeignKey("dbo.Property", t => t.Property_PropertyId, cascadeDelete: true)
                .Index(t => t.Tenant_TenantId)
                .Index(t => t.Property_PropertyId);
            
            DropColumn("dbo.Owner", "PurchaseDate");
            DropColumn("dbo.Owner", "OwnedDuration");
            DropColumn("dbo.Owner", "PurchasePrice");
            DropColumn("dbo.Owner", "DownPayment");
            DropColumn("dbo.Owner", "MortgageAmount");
            DropColumn("dbo.Tenant", "PropertyId");
            DropColumn("dbo.Tenant", "Address");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tenant", "Address", c => c.String());
            AddColumn("dbo.Tenant", "PropertyId", c => c.Int(nullable: false));
            AddColumn("dbo.Owner", "MortgageAmount", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Owner", "DownPayment", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Owner", "PurchasePrice", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.Owner", "OwnedDuration", c => c.Time(nullable: false, precision: 7));
            AddColumn("dbo.Owner", "PurchaseDate", c => c.DateTime(nullable: false));
            DropForeignKey("dbo.TenantProperty", "Property_PropertyId", "dbo.Property");
            DropForeignKey("dbo.TenantProperty", "Tenant_TenantId", "dbo.Tenant");
            DropIndex("dbo.TenantProperty", new[] { "Property_PropertyId" });
            DropIndex("dbo.TenantProperty", new[] { "Tenant_TenantId" });
            DropTable("dbo.TenantProperty");
            CreateIndex("dbo.Tenant", "PropertyId");
            AddForeignKey("dbo.Tenant", "PropertyId", "dbo.Property", "PropertyId", cascadeDelete: true);
        }
    }
}

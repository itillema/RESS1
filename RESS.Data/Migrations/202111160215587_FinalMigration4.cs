namespace RESS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FinalMigration4 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.TenantProperty", "Tenant_TenantId", "dbo.Tenant");
            DropForeignKey("dbo.TenantProperty", "Property_PropertyId", "dbo.Property");
            DropIndex("dbo.TenantProperty", new[] { "Tenant_TenantId" });
            DropIndex("dbo.TenantProperty", new[] { "Property_PropertyId" });
            DropTable("dbo.TenantProperty");
        }
        
        public override void Down()
        {
            CreateTable(
                "dbo.TenantProperty",
                c => new
                    {
                        Tenant_TenantId = c.Int(nullable: false),
                        Property_PropertyId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Tenant_TenantId, t.Property_PropertyId });
            
            CreateIndex("dbo.TenantProperty", "Property_PropertyId");
            CreateIndex("dbo.TenantProperty", "Tenant_TenantId");
            AddForeignKey("dbo.TenantProperty", "Property_PropertyId", "dbo.Property", "PropertyId", cascadeDelete: true);
            AddForeignKey("dbo.TenantProperty", "Tenant_TenantId", "dbo.Tenant", "TenantId", cascadeDelete: true);
        }
    }
}

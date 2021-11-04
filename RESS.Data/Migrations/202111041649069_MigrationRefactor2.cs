namespace RESS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrationRefactor2 : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Property", "TenantId", "dbo.Tenant");
            DropForeignKey("dbo.Owner", "PropertyId", "dbo.Property");
            DropForeignKey("dbo.Property", "Owner_OwnerId", "dbo.Owner");
            DropForeignKey("dbo.Tenant", "Property_PropertyId", "dbo.Property");
            DropIndex("dbo.Owner", new[] { "PropertyId" });
            DropIndex("dbo.Property", new[] { "OwnerId" });
            DropIndex("dbo.Property", new[] { "TenantId" });
            DropIndex("dbo.Property", new[] { "Owner_OwnerId" });
            DropIndex("dbo.Tenant", new[] { "PropertyId" });
            DropIndex("dbo.Tenant", new[] { "Property_PropertyId" });
            DropColumn("dbo.Property", "OwnerId");
            DropColumn("dbo.Tenant", "PropertyId");
            RenameColumn(table: "dbo.Property", name: "Owner_OwnerId", newName: "OwnerId");
            RenameColumn(table: "dbo.Tenant", name: "Property_PropertyId", newName: "PropertyId");
            AddColumn("dbo.Property", "OwnerFirstName", c => c.String());
            AddColumn("dbo.Property", "OwnerLastName", c => c.String());
            AlterColumn("dbo.Property", "OwnerId", c => c.Int(nullable: false));
            AlterColumn("dbo.Tenant", "PropertyId", c => c.Int(nullable: false));
            CreateIndex("dbo.Property", "OwnerId");
            CreateIndex("dbo.Tenant", "PropertyId");
            //AddForeignKey("dbo.Property", "OwnerId", "dbo.Owner", "OwnerId", cascadeDelete: true);
            AddForeignKey("dbo.Tenant", "PropertyId", "dbo.Property", "PropertyId", cascadeDelete: true);
            DropColumn("dbo.Owner", "PropertyId");
            DropColumn("dbo.Owner", "Address");
            DropColumn("dbo.Property", "TenantId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Property", "TenantId", c => c.Int(nullable: false));
            AddColumn("dbo.Owner", "Address", c => c.String());
            AddColumn("dbo.Owner", "PropertyId", c => c.Int(nullable: false));
            DropForeignKey("dbo.Tenant", "PropertyId", "dbo.Property");
            DropForeignKey("dbo.Property", "OwnerId", "dbo.Owner");
            DropIndex("dbo.Tenant", new[] { "PropertyId" });
            DropIndex("dbo.Property", new[] { "OwnerId" });
            AlterColumn("dbo.Tenant", "PropertyId", c => c.Int());
            AlterColumn("dbo.Property", "OwnerId", c => c.Int());
            DropColumn("dbo.Property", "OwnerLastName");
            DropColumn("dbo.Property", "OwnerFirstName");
            RenameColumn(table: "dbo.Tenant", name: "PropertyId", newName: "Property_PropertyId");
            RenameColumn(table: "dbo.Property", name: "OwnerId", newName: "Owner_OwnerId");
            AddColumn("dbo.Tenant", "PropertyId", c => c.Int(nullable: false));
            AddColumn("dbo.Property", "OwnerId", c => c.Int(nullable: false));
            CreateIndex("dbo.Tenant", "Property_PropertyId");
            CreateIndex("dbo.Tenant", "PropertyId");
            CreateIndex("dbo.Property", "Owner_OwnerId");
            CreateIndex("dbo.Property", "TenantId");
            CreateIndex("dbo.Property", "OwnerId");
            CreateIndex("dbo.Owner", "PropertyId");
            AddForeignKey("dbo.Tenant", "Property_PropertyId", "dbo.Property", "PropertyId");
            AddForeignKey("dbo.Property", "Owner_OwnerId", "dbo.Owner", "OwnerId");
            AddForeignKey("dbo.Owner", "PropertyId", "dbo.Property", "PropertyId", cascadeDelete: true);
            AddForeignKey("dbo.Property", "TenantId", "dbo.Tenant", "TenantId", cascadeDelete: true);
        }
    }
}

namespace RosondDeveloperTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class first : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Vehicles", name: "BranchId", newName: "Branch_ID");
            RenameColumn(table: "dbo.Vehicles", name: "SupplierId", newName: "Supplier_ID");
            RenameColumn(table: "dbo.Vehicles", name: "ClientId", newName: "Client_ID");
            RenameColumn(table: "dbo.Vehicles", name: "DriverId", newName: "Driver_ID");
            RenameIndex(table: "dbo.Vehicles", name: "IX_SupplierId", newName: "IX_Supplier_ID");
            RenameIndex(table: "dbo.Vehicles", name: "IX_BranchId", newName: "IX_Branch_ID");
            RenameIndex(table: "dbo.Vehicles", name: "IX_ClientId", newName: "IX_Client_ID");
            RenameIndex(table: "dbo.Vehicles", name: "IX_DriverId", newName: "IX_Driver_ID");
            AlterColumn("dbo.Branches", "BranchContactNumber", c => c.Long(nullable: false));
            AlterColumn("dbo.Clients", "ClientContactNumber", c => c.Long(nullable: false));
            AlterColumn("dbo.Drivers", "DriverContactNumber", c => c.Long(nullable: false));
            DropColumn("dbo.Clients", "ClientContactPerson");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Clients", "ClientContactPerson", c => c.String());
            AlterColumn("dbo.Drivers", "DriverContactNumber", c => c.String());
            AlterColumn("dbo.Clients", "ClientContactNumber", c => c.Single(nullable: false));
            AlterColumn("dbo.Branches", "BranchContactNumber", c => c.String());
            RenameIndex(table: "dbo.Vehicles", name: "IX_Driver_ID", newName: "IX_DriverId");
            RenameIndex(table: "dbo.Vehicles", name: "IX_Client_ID", newName: "IX_ClientId");
            RenameIndex(table: "dbo.Vehicles", name: "IX_Branch_ID", newName: "IX_BranchId");
            RenameIndex(table: "dbo.Vehicles", name: "IX_Supplier_ID", newName: "IX_SupplierId");
            RenameColumn(table: "dbo.Vehicles", name: "Driver_ID", newName: "DriverId");
            RenameColumn(table: "dbo.Vehicles", name: "Client_ID", newName: "ClientId");
            RenameColumn(table: "dbo.Vehicles", name: "Supplier_ID", newName: "SupplierId");
            RenameColumn(table: "dbo.Vehicles", name: "Branch_ID", newName: "BranchId");
        }
    }
}

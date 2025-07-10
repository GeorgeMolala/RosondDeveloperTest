namespace RosondDeveloperTest.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        Branch_ID = c.Int(nullable: false, identity: true),
                        BranchName = c.String(nullable: false),
                        BranchContactPerson = c.String(),
                        BranchContactNumber = c.String(),
                        BranchEmail = c.String(),
                        Prov_ID = c.Int(nullable: false),
                        City_ID = c.Int(nullable: false),
                        AddressLine1 = c.String(),
                        AddressLine2 = c.String(),
                        PostalCode = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Branch_ID);
            
            CreateTable(
                "dbo.BranchSupplierLinks",
                c => new
                    {
                        BranchSupplier_ID = c.Int(nullable: false, identity: true),
                        Branch_ID = c.Int(nullable: false),
                        Supplier_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BranchSupplier_ID)
                .ForeignKey("dbo.Branches", t => t.Branch_ID, cascadeDelete: true)
                .ForeignKey("dbo.Suppliers", t => t.Supplier_ID, cascadeDelete: true)
                .Index(t => t.Branch_ID)
                .Index(t => t.Supplier_ID);
            
            CreateTable(
                "dbo.Suppliers",
                c => new
                    {
                        Supplier_ID = c.Int(nullable: false, identity: true),
                        SupplierName = c.String(nullable: false),
                        SupplierContactPerson = c.String(),
                        SupplierEmail = c.String(),
                        Prov_ID = c.Int(nullable: false),
                        City_ID = c.Int(nullable: false),
                        AddressLine1 = c.String(),
                        AddressLine2 = c.String(),
                        PostalCode = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Supplier_ID);
            
            CreateTable(
                "dbo.Vehicles",
                c => new
                    {
                        Vehicle_ID = c.Int(nullable: false, identity: true),
                        Manufacturer = c.String(nullable: false),
                        Model = c.String(),
                        Year = c.Int(nullable: false),
                        VehicleLisencePlate = c.String(),
                        SupplierId = c.Int(nullable: false),
                        BranchId = c.Int(nullable: false),
                        ClientId = c.Int(nullable: false),
                        DriverId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Vehicle_ID)
                .ForeignKey("dbo.Branches", t => t.BranchId, cascadeDelete: true)
                .ForeignKey("dbo.Clients", t => t.ClientId, cascadeDelete: true)
                .ForeignKey("dbo.Drivers", t => t.DriverId, cascadeDelete: true)
                .ForeignKey("dbo.Suppliers", t => t.SupplierId, cascadeDelete: true)
                .Index(t => t.SupplierId)
                .Index(t => t.BranchId)
                .Index(t => t.ClientId)
                .Index(t => t.DriverId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        Client_ID = c.Int(nullable: false, identity: true),
                        ClientName = c.String(),
                        ClientContactPerson = c.String(),
                        ClientContactNumber = c.Single(nullable: false),
                        ClientEmail = c.String(),
                        Prov_ID = c.Int(nullable: false),
                        City_ID = c.Int(nullable: false),
                        AddressLine1 = c.String(),
                        AddressLine2 = c.String(),
                        PostalCode = c.Single(nullable: false),
                    })
                .PrimaryKey(t => t.Client_ID);
            
            CreateTable(
                "dbo.Drivers",
                c => new
                    {
                        Driver_ID = c.Int(nullable: false, identity: true),
                        DriverName = c.String(nullable: false),
                        DriverContactNumber = c.String(),
                        DriverEmail = c.String(),
                        Branch_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Driver_ID)
                .ForeignKey("dbo.Branches", t => t.Branch_ID, cascadeDelete: true)
                .Index(t => t.Branch_ID);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        City_ID = c.Int(nullable: false, identity: true),
                        CityName = c.String(),
                        Prov_ID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.City_ID)
                .ForeignKey("dbo.Provinces", t => t.Prov_ID, cascadeDelete: true)
                .Index(t => t.Prov_ID);
            
            CreateTable(
                "dbo.Provinces",
                c => new
                    {
                        Prov_ID = c.Int(nullable: false, identity: true),
                        ProvinceName = c.String(),
                    })
                .PrimaryKey(t => t.Prov_ID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "Prov_ID", "dbo.Provinces");
            DropForeignKey("dbo.BranchSupplierLinks", "Supplier_ID", "dbo.Suppliers");
            DropForeignKey("dbo.Vehicles", "SupplierId", "dbo.Suppliers");
            DropForeignKey("dbo.Vehicles", "DriverId", "dbo.Drivers");
            DropForeignKey("dbo.Drivers", "Branch_ID", "dbo.Branches");
            DropForeignKey("dbo.Vehicles", "ClientId", "dbo.Clients");
            DropForeignKey("dbo.Vehicles", "BranchId", "dbo.Branches");
            DropForeignKey("dbo.BranchSupplierLinks", "Branch_ID", "dbo.Branches");
            DropIndex("dbo.Cities", new[] { "Prov_ID" });
            DropIndex("dbo.Drivers", new[] { "Branch_ID" });
            DropIndex("dbo.Vehicles", new[] { "DriverId" });
            DropIndex("dbo.Vehicles", new[] { "ClientId" });
            DropIndex("dbo.Vehicles", new[] { "BranchId" });
            DropIndex("dbo.Vehicles", new[] { "SupplierId" });
            DropIndex("dbo.BranchSupplierLinks", new[] { "Supplier_ID" });
            DropIndex("dbo.BranchSupplierLinks", new[] { "Branch_ID" });
            DropTable("dbo.Provinces");
            DropTable("dbo.Cities");
            DropTable("dbo.Drivers");
            DropTable("dbo.Clients");
            DropTable("dbo.Vehicles");
            DropTable("dbo.Suppliers");
            DropTable("dbo.BranchSupplierLinks");
            DropTable("dbo.Branches");
        }
    }
}

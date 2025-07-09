using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RosondDeveloperTest.Models
{
    public class Vehicle
    {
        [Key]
        public int Vehicle_ID { get; set; }


        [Required]
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string VehicleLisencePlate { get; set; }



        [ForeignKey("Supplier")]
        public int SupplierId { get; set; }
        public virtual Supplier Supplier { get; set; }



        [ForeignKey("Branch")]
        public int BranchId { get; set; }
        public virtual Branch Branch { get; set; }



        [ForeignKey("Client")]
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }



        [ForeignKey("Driver")]
        public int DriverId { get; set; }
        public virtual Driver Driver { get; set; }
    }
}
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
        public int Supplier_ID{ get; set; }
        public virtual Supplier Supplier { get; set; }



        [ForeignKey("Branch")]
        public int Branch_ID { get; set; }
        public virtual Branch Branch { get; set; }



        [ForeignKey("Client")]
        public int Client_ID { get; set; }
        public virtual Client Client { get; set; }



        [ForeignKey("Driver")]
        public int Driver_ID { get; set; }
        public virtual Driver Driver { get; set; }
    }
}
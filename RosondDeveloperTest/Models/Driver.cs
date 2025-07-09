using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RosondDeveloperTest.Models
{
    public class Driver
    {
        [Key]
        public int Driver_ID { get; set; }


        [Required]
        public string DriverName { get; set; }

        public string DriverContactNumber { get; set; }

        public string DriverEmail { get; set; }


        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
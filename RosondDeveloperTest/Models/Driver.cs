using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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

        public long DriverContactNumber { get; set; }

        public string DriverEmail { get; set; }

        [ForeignKey("Branch")]
        public int Branch_ID { get; set; }
        public virtual Branch Branch { get; set; }

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
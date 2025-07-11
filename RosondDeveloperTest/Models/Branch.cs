using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RosondDeveloperTest.Models
{
    public class Branch
    {
        [Key]
        public int Branch_ID { get; set; }
        [Required]


        public string BranchName { get; set; }

        public string BranchContactPerson { get; set; }

        public long BranchContactNumber { get; set; }

        public string BranchEmail { get; set; }


        //Branch Address
        public int Prov_ID { get; set; }

        public int City_ID { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public float PostalCode { get; set; }


        public virtual ICollection<Vehicle> Vehicles { get; set; }
        public virtual ICollection<Driver> Drivers { get; set; }
        public virtual ICollection<BranchSupplierLink> BranchSupplierLinks { get; set; }
    }
}
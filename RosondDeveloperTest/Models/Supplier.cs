using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RosondDeveloperTest.Models
{
    public class Supplier
    {
        [Key]
        public int Supplier_ID { get; set; }

        [Required]
        public string SupplierName { get; set; }

        public string SupplierContactPerson { get; set; }


        public string SupplierEmail { get; set; }


        //Supplier Address
        public int Prov_ID { get; set; }

        public int City_ID { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public float PostalCode { get; set; }


        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
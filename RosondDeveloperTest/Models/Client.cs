using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RosondDeveloperTest.Models
{
    public class Client
    {
        [Key]
        public int Client_ID { get; set; }

        public string ClientName { get; set; }

        public string ClientContactPerson { get; set; }

        public float ClientContactNumber { get; set; }

        public string ClientEmail { get; set; }


        //Client Address
        public int Prov_ID { get; set; }

        public int City_ID { get; set; }

        public string AddressLine1 { get; set; }

        public string AddressLine2 { get; set; }

        public float PostalCode { get; set; }


        public virtual ICollection<Vehicle> Vehicles { get; set; }


    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RosondDeveloperTest.Models
{
    public class City
    {
        [Key]
        public int City_ID { get; set; }

        public string CityName { get; set; }


        [ForeignKey("Province")]
        public int Prov_ID { get; set; }
        public virtual Province Province { get; set; }

        
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RosondDeveloperTest.Models
{
    public class City
    {
        [Key]
        public int City_ID { get; set; }

        public string CityName { get; set; }

        
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RosondDeveloperTest.Models
{
    public class Province
    {

        [Key]
        public int Prov_ID { get; set; }

        public string ProvinceName { get; set; }
    }
}
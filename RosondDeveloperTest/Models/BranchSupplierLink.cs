using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RosondDeveloperTest.Models
{
    public class BranchSupplierLink
    {
        [Key]
        public int BranchSupplier_ID { get; set; }


        [ForeignKey("Branch")]
        public int Branch_ID { get; set; }
        public virtual Branch Branch { get; set; }


        [ForeignKey("Supplier")]
        public int Supplier_ID { get; set; }
        public virtual Supplier Supplier { get; set; }
    }
}
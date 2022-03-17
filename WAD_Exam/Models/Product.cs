using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WAD_Exam.Models
{
    public class Product
    {
        [Key]
        public string ProductID { get; set; }

        public string ProductName { get; set; }
        public string SupplierID { get; set; }

        [ForeignKey("Category")]
        public string CategoryID { get; set; }

        public double QuantityPerUnit { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        public int UnitsOnOrder { get; set; }
        public int ReorderLevel { get; set; }
        public int Discontinued { get; set; }
        public virtual Category Category { get; set; }
    }
}
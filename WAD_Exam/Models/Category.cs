using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WAD_Exam.Models
{
    public class Category
    {
        [Key]
        public string CategoryID { get; set; }

        public string CategoryName { get; set; }
        public string Description { get; set; }
        public string Picture { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
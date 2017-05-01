using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Sportscasters_final.Models
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name = "Number")]
        public int ProductID { get; set; }

        [StringLength(30, MinimumLength = 3)]
        public string ProductName { get; set; }
        [Range(1000, 5000)]
        public int UPC { get; set; }
        [StringLength(30, MinimumLength = 3)]
        public string DepartmentName { get; set; }

        public decimal Price { get; set; }
        [Range(0, 100)]
        public int Inventory { get; set; }
        
        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual Department Department { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }


    }
}
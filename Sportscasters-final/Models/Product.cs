using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sportscasters_final.Models
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int UPC { get; set; }
        public int DepartmentID { get; set; }
        public decimal Price { get; set; }
        public int Inventory { get; set; }
        
        public virtual ICollection<Transaction> Transactions { get; set; }


    }
}
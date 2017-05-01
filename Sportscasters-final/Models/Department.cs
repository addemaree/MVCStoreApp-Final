using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sportscasters_final.Models
{
    public class Department
    {
        public int DepartmentID { get; set; }
        [StringLength(30, MinimumLength = 3)]
        public string Name { get; set; }
        [DataType(DataType.Currency)]
        public decimal TotalSales { get; set; }

        public virtual ICollection<Assignment> Assignments { get; set; }


    }
}
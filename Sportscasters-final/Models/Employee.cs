using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sportscasters_final.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public DateTime HireDate { get; set; }


        public virtual ICollection<Transaction> Transactions { get; set; }


    }
}
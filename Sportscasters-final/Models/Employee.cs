using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sportscasters_final.Models
{
    public class Employee
    {
        public int EmployeeID { get; set; }

        [Required]
        [Display(Name ="Last Name")]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [Column("FirstName")]
        [Display(Name = "First Name")]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [Display(Name ="Hire Date")]
        public DateTime HireDate { get; set; }


        [Display(Name = "Full Name")]
        public string FullName
        {
            get { return LastName + ", " + FirstName; }
        }

        public virtual ICollection<Transaction> Transactions { get; set; }
        public virtual ICollection<Assignment> Assignments { get; set; }



    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Sportscasters_final.Models
{
    public class Customer
    {
        public int CustomerID { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        [Required]
        [StringLength(50, ErrorMessage ="First name cannot be longer than 50 characters long.")]
        [Column("FirstName")]
        [Display(Name = "FirstName")]
        public string FirstName { get; set; }
        [StringLength(30)]
        [Display(Name = "Last Purchase")]
        public string LastPurchase { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Purchase Date")]
        public DateTime PurchaseDate { get; set; }

        [Display(Name ="Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstName;
            }
        }

        public virtual ICollection<Transaction> Transactions { get; set; }

    }
}
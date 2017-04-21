using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Sportscasters_final.ViewModels
{
    public class TransactionDateGroup
    {
        [DataType(DataType.Date)]
        public DateTime? TransactionDate { get; set; }

        public int CustomerCount { get; set; }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Sportscasters_final.Models;

namespace Sportscasters_final.ViewModels
{
    public class EmployeeIndexData
    {
        public IEnumerable<Employee> Employees { get; set; }
        public Product Products { get; set; }
        public IEnumerable<Transaction> Transactions { get; set; }

    }
}
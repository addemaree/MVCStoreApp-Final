using Sportscasters_final.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sportscasters_final.DAL
{
    class StoreInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<StoreContext>
    {
        protected override void Seed(StoreContext context)
        {
            var customers = new List<Customer>
          {
              new Customer{LastName= "Demaree", FirstName= "Adam", PurchaseDate=DateTime.Parse("2017-02-14")},
              new Customer{LastName= "Lohsl", FirstName= "Brad", PurchaseDate=DateTime.Parse("2017-02-14")},
              new Customer{LastName= "Lower", FirstName= "Anthony", PurchaseDate=DateTime.Parse("2017-02-14")},
              new Customer{LastName= "Winters", FirstName= "Lauren", PurchaseDate=DateTime.Parse("2017-02-14")},
              new Customer{LastName= "Demaree", FirstName= "Sam", PurchaseDate=DateTime.Parse("2017-02-14")}
          };
            customers.ForEach(c => context.Customers.Add(c));
            context.SaveChanges();

            var employees = new List<Employee>
            {
                new Employee{LastName= "Condry", FirstName= "Paul", HireDate=DateTime.Parse("")},
                new Employee{LastName= "Condry", FirstName= "Leah", HireDate=DateTime.Parse("")},
                new Employee{LastName= "Joubert", FirstName= "JP", HireDate=DateTime.Parse("")},
                new Employee{LastName= "Kopsea", FirstName= "Matt", HireDate=DateTime.Parse("")},
                new Employee{LastName= "Knezevich", FirstName= "Mike", HireDate=DateTime.Parse("")}
            };
            employees.ForEach(e => context.Employees.Add(e));
            context.SaveChanges();

            var products = new List<Product>
            {
                new Product{ProductName = "Headset", UPC = 23044, Price = 49.99M, Inventory = 5},
                new Product{ProductName = "Microphone", UPC = 23045, Price = 49.99M, Inventory = 5},
                new Product{ProductName = "Video Camera", UPC = 23046, Price = 249.99M, Inventory = 5},
                new Product{ProductName = "Auxillary Cords", UPC = 23047, Price = 29.99M, Inventory = 5},
                new Product{ProductName = "Mixer", UPC = 23048, Price = 149.99M, Inventory = 5}
            };
            products.ForEach(p => context.Products.Add(p));
            context.SaveChanges();

            var transactions = new List<Transaction>
            {
                new Transaction{CustomerID = 1, ProductID = 1, EmployeeID = 3},
                new Transaction{CustomerID = 2, ProductID = 2, EmployeeID = 2},
                new Transaction{CustomerID = 3, ProductID = 3, EmployeeID = 2},
                new Transaction{CustomerID = 4, ProductID = 4, EmployeeID = 1},
                new Transaction{CustomerID = 5, ProductID = 5, EmployeeID = 4},
                new Transaction{CustomerID = 6, ProductID = 6, EmployeeID = 4}
            };
        }
    }
}
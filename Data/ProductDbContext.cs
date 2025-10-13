using Microsoft.EntityFrameworkCore;
using Test_MVC.Models;

namespace Test_MVC.Data
{
    public class ProductDbContext
    {
        public static readonly List<Product> products = new List<Product>
        {
            new Product { ProductID = 1, Description = "Laptop", Category = "Electronics", Country = "USA" },
            new Product { ProductID = 2, Description = "Smartphone", Category = "Electronics", Country = "China" },
            new Product { ProductID = 3, Description = "Tablet", Category = "Electronics", Country = "South Korea" },
            new Product { ProductID = 4, Description = "Headphones", Category = "Accessories", Country = "Germany" },
            new Product { ProductID = 5, Description = "Smartwatch", Category = "Wearables", Country = "Switzerland" }
        };

    }
}

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product { ProductID = 1, ProductName = "Chai", Category = "Beverages", UnitPrice = 18, UnitsInStock = 39 },
                new Product { ProductID = 2, ProductName = "Chang", Category = "Beverages", UnitPrice = 19, UnitsInStock = 17 },
                new Product { ProductID = 3, ProductName = "Aniseed Syrup", Category = "Condiments", UnitPrice = 10, UnitsInStock = 13 },
                new Product { ProductID = 4, ProductName = "Chef Anton", Category = "Condiments", UnitPrice = 22, UnitsInStock = 53 },
                new Product { ProductID = 5, ProductName = "Ikura", Category = "Seafood", UnitPrice = 31, UnitsInStock = 20 },
                new Product { ProductID = 6, ProductName = "Konbu", Category = "Seafood", UnitPrice = 6, UnitsInStock = 0 },
                new Product { ProductID = 7, ProductName = "Tofu", Category = "Produce", UnitPrice = 23, UnitsInStock = 35 },
                new Product { ProductID = 8, ProductName = "Pavlova", Category = "Confections", UnitPrice = 17, UnitsInStock = 29 }
            };
            #region Q1
            //var top3 = products
            //.OrderByDescending(p => p.UnitPrice)
            //.Take(3); 
            #endregion
        }
    }
}

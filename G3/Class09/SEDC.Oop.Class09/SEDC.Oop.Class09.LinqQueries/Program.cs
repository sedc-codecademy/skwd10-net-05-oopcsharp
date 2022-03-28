using SEDC.Oop.Class09.LinqQueries.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SEDC.Oop.Class09.LinqQueries
{
    class Program
    {
        //Search products by category // return all products from given category
        //Filter products by price range(from min to max) // return all products that fall in the given price range
        //Find products by part of name // get all products that consist the part in their names
        //Get only products ids // return only the ids of the products
        //Get product price // get the price of the product - give the id as parameter
        //Get cheapest product // return the cheapest product
        //Get most expensive product // return the most expensive one
        //Add product // create method to add product to the list of products
        //Remove product // and a method to remove it - use id as parameter
        //Don't forget to create class Product
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                new Product() { Id = 1, Name =  "Keyboard", Price = 100, Category = Category.ItEquipment},
                new Product() { Id = 2, Name =  "Mouse", Price = 150, Category = Category.ItEquipment},
                new Product() { Id = 3, Name =  "Headphones", Price = 80, Category = Category.ItEquipment},
                new Product() { Id = 4, Name =  "Microphone", Price = 220, Category = Category.ItEquipment},
                new Product() { Id = 5, Name =  "Camera", Price = 1000, Category = Category.ItEquipment},
                new Product() { Id = 6, Name =  "Hp-580", Price = 20000, Category = Category.LapTop},
                new Product() { Id = 7, Name =  "Lenovo G200", Price = 18500, Category = Category.LapTop},
                new Product() { Id = 8, Name =  "Hp ProBook", Price = 12000, Category = Category.LapTop},
                new Product() { Id = 9, Name =  "Acer S1200", Price = 28000, Category = Category.LapTop},
                new Product() { Id = 10, Name =  "Dell MS300", Price = 74000, Category = Category.LapTop},
                new Product() { Id = 11, Name =  "Office 1", Price = 10200, Category = Category.PC},
                new Product() { Id = 12, Name =  "Office 2", Price = 12400, Category = Category.PC},
                new Product() { Id = 13, Name =  "Gaming", Price = 22000, Category = Category.PC},
                new Product() { Id = 14, Name =  "Ultra Gaming", Price = 32200, Category = Category.PC},
                new Product() { Id = 15, Name =  "Ultra Ultra Gaming", Price = 61600, Category = Category.PC},
                new Product() { Id = 16, Name =  "Alienware", Price = 128000, Category = Category.PC},
                new Product() { Id = 17, Name =  "Samsung Proview", Price = 56200, Category = Category.TV},
                new Product() { Id = 18, Name =  "LG LG420MQ8", Price = 32000, Category = Category.TV},
                new Product() { Id = 19, Name =  "SONY Plasma", Price = 18000, Category = Category.TV},
                new Product() { Id = 20, Name =  "SONY RW78OS", Price = 179999, Category = Category.TV},
                new Product() { Id = 21, Name =  "Samsung Oval", Price = 247999, Category = Category.TV}
            };

            List<Product> allTV = SearchProductsByCategoryWithoutLinq(products, Category.TV);
            Console.WriteLine("=========== SearchProductsByCategoryWithoutLinq ===========");
            PrintProductInfo(allTV);
            Console.WriteLine("=========== SearchProductsByCategoryWithLinq ===========");
            List<Product> allTVLinq = SearchProductsByCategoryWithLinq(products, Category.TV);
            PrintProductInfo(allTVLinq);

            Console.WriteLine("=========== FilterProductsByPriceRangeWithoutLinq ===========");
            List<Product> minMaxPrice = FilterProductsByPriceRangeWithoutLinq(products, 500, 1000);
            PrintProductInfo(minMaxPrice);
            Console.WriteLine("=========== FilterProductsByPriceRangeWithLinq ===========");
            List<Product> minMaxPrice1 = FilterProductsByPriceRangeWithLinq(products, 500, 1000);
            PrintProductInfo(minMaxPrice1);

            Console.WriteLine("=========== GetProductIdsWithoutLinq ===========");
            List<int> ids = GetProductIdsWithoutLinq(products);
            foreach (int id in ids)
            {
                Console.WriteLine(id);
            }
            Console.WriteLine("=========== GetProductIdsWithLinq ===========");
            List<int> ids1 = GetProductIdsWithLinq(products);
            foreach (int id in ids1)
            {
                Console.WriteLine(id);
            }

            List<string> namesByCategory = products
                .Where(p => p.Category == Category.LapTop)
                .Select(x => x.Name)
                .ToList();

            List<Product> filterFirstByPriceThenByCategory = products
                .Where(x => x.Price >= 1000 && x.Price <= 100000)
                .Where(x => x.Category == Category.PC)
                .ToList();

            List<string> filterByCategoryThenGetNamesThenFilterByStartingLetter = products
                .Where(x => x.Category == Category.PC)
                .Select(x => x.Name)
                .Where(x => x.StartsWith("O"))
                .ToList();

            //valid
            Product startsWithO = products.First(x => x.Name.StartsWith("O"));
            // will throw exception
            Product startsWithO1 = products.First(x => x.Name.StartsWith("1"));
            // wiill return null
            //Product startsWithO1 = products.FirstOrDefault(x => x.Name.StartsWith("1"));

            // valid    
            Product lastStartsWithO = products.Last(x => x.Name.StartsWith("O"));
            // will throw exception
            //Product lastStartsWithO1 = products.Last(x => x.Name.StartsWith("1"));
            // wiill return null
            Product lastStartsWithO2 = products.LastOrDefault(x => x.Name.StartsWith("1"));

            int filterByCategoryGetPricesGetLastPrice = products
                .Where(x => x.Category == Category.ItEquipment)
                .Select(x => x.Price)
                .LastOrDefault();

            Console.ReadLine();
        }

        public static List<Product> SearchProductsByCategoryWithoutLinq(List<Product> products, Category category)
        {
            List<Product> listOfProducts = new List<Product>();
            foreach(Product product in products)
            {
                if(product.Category == category)
                {
                    listOfProducts.Add(product);
                }
            }
            return listOfProducts;
        }

        public static List<Product> SearchProductsByCategoryWithLinq(List<Product> products, Category category)
        {
            List<Product> filteredProducts = products.Where(product => product.Category == category).ToList();
            return filteredProducts;
        }

        public static List<Product> FilterProductsByPriceRangeWithoutLinq(List<Product> products, int minPrice, int maxPrice)
        {
            List<Product> listOfProducts = new List<Product>();
            foreach (Product product in products)
            {
                if(product.Price >= minPrice && product.Price <= maxPrice)
                {
                    listOfProducts.Add(product);
                }
            }
            return listOfProducts;
        }

        public static List<Product> FilterProductsByPriceRangeWithLinq(List<Product> products, int minPrice, int maxPrice)
        {
            //Where with multiple lines in labda
            List<Product> products1 = products.Where(p => {
                    bool isValid = p.Price >= minPrice && p.Price <= maxPrice;
                    return isValid;
                }).ToList();
            return products1;
        }

        public static List<int> GetProductIdsWithoutLinq(List<Product> products)
        {
            List<int> ids = new List<int>();
            foreach (Product product in products)
            {
                ids.Add(product.Id);
            }
            return ids;
        }

        public static List<int> GetProductIdsWithLinq(List<Product> products)
        {
            List<int> ids = products.Select(p => p.Id).ToList();
            return ids;
        }

        public static void PrintProductInfo(List<Product> products)
        {
            foreach (Product item in products)
            {
                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Price: {item.Price}, Category: {item.Category}");
            }
        }
    }
}

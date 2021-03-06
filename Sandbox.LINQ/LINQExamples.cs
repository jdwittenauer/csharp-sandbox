﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Sandbox.LINQ
{
    /// <summary>
    /// Learning exercie for LINQ queries.
    /// </summary>
    public static class LINQExamples
    {
        public static void Run()
        {
            Console.WriteLine("LINQ examples");
            Console.WriteLine("------------------------------");
            Console.WriteLine("");

            Linq1();
            Linq2();
            Linq3();
            Linq4();
            Linq5();
            Linq6();
            Linq7();
            Linq8();
            Linq9();
            Linq10();
            Linq11();
            Linq12();
            Linq13();
            Linq14();
            Linq15();
            Linq16();
            Linq17();
            Linq18();
            Linq19();
            Linq20();
            Linq21();
            Linq22();
            Linq23();
            Linq24();
            Linq25();
            Linq26();
            Linq27();
            Linq28();
            Linq29();
            Linq30();
            Linq31();
            Linq32();
            Linq33();
            Linq34();
            Linq35();
            Linq36();

            Console.WriteLine("Example complete. Press a key to proceed.");
            Console.ReadKey();
            Console.WriteLine("");
        }

        private static void Linq1()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // Where
            var result =
                from num in numbers
                where num < 5
                select num;

            // Alternate syntax
            var result2 = numbers.Where(x => x < 5);

            Console.WriteLine("Numbers < 5:");
            foreach (var x in result)
            {
                Console.WriteLine(x);
            }

            Console.ReadLine();
        }

        private static void Linq2()
        {
            List<Product> products = GetProductList();

            // Where #2
            var result =
                from prod in products
                where prod.UnitsInStock > 0 && prod.UnitPrice > 3.00M
                select prod;

            // Alternate syntax
            var result2 = products.Where(x => x.UnitsInStock > 0 && x.UnitPrice > 3.00M);

            Console.WriteLine("In-stock products that cost more than 3.00:");
            foreach (var product in result)
            {
                Console.WriteLine("{0} is in stock and costs more than 3.00.", product.ProductName);
            }

            Console.ReadLine();
        }

        private static void Linq3()
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            // Where with index
            var result = digits.Where((digit, index) => digit.Length < index);

            Console.WriteLine("Short digits:");
            foreach (var d in result)
            {
                Console.WriteLine("The word {0} is shorter than its value.", d);
            }

            Console.ReadLine();
        }

        private static void Linq4()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // Select
            var result =
                from num in numbers
                select num + 1;

            // Alternate syntax
            var result2 = numbers.Select(x => x + 1);

            Console.WriteLine("Numbers + 1:");
            foreach (var i in result)
            {
                Console.WriteLine(i);
            }

            Console.ReadLine();
        }

        private static void Linq5()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            // Select with transformation
            var result =
                from num in numbers
                select strings[num];

            // Alternate syntax
            var result2 = numbers.Select(x => strings[x]);

            Console.WriteLine("Number strings:");
            foreach (var str in result)
            {
                Console.WriteLine(str);
            }

            Console.ReadLine();
        }

        private static void Linq6()
        {
            List<Product> products = GetProductList();

            // Select with type projection
            var result =
                from prod in products
                select new { prod.ProductName, prod.Category, Price = prod.UnitPrice };

            // Alternate syntax
            var result2 = products.Select(x => new { x.ProductName, x.Category, Price = x.UnitPrice });

            Console.WriteLine("Product Info:");
            foreach (var productInfo in result)
            {
                Console.WriteLine("{0} is in the category {1} and costs {2} per unit.", productInfo.ProductName, productInfo.Category, productInfo.Price);
            }

            Console.ReadLine();
        }

        private static void Linq7()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // Select with index
            var result = numbers.Select((num, index) => new { Num = num, InPlace = (num == index) });

            Console.WriteLine("Number: In-place?");
            foreach (var n in result)
            {
                Console.WriteLine("{0}: {1}", n.Num, n.InPlace);
            }

            Console.ReadLine();
        }

        private static void Linq8()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            // Select many
            var result =
                from a in numbersA
                from b in numbersB
                where a < b
                select new { a, b };

            // Alternate syntax
            var result2 = numbersA.SelectMany(a => numbersB.Where(b => a < b), (a, b) => new { a, b });

            Console.WriteLine("Pairs where a < b:");
            foreach (var pair in result)
            {
                Console.WriteLine("{0} is less than {1}", pair.a, pair.b);
            }

            Console.ReadLine();
        }

        private static void Linq9()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // Take
            var result = numbers.Take(3);

            Console.WriteLine("First 3 numbers:");
            foreach (var n in result)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();
        }

        private static void Linq10()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // Skip
            var result = numbers.Skip(4);

            Console.WriteLine("All but first 4 numbers:");
            foreach (var n in result)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();
        }

        private static void Linq11()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // Take while
            var result = numbers.TakeWhile(n => n < 6);

            Console.WriteLine("First numbers less than 6:");
            foreach (var num in result)
            {
                Console.WriteLine(num);
            }

            Console.ReadLine();
        }

        private static void Linq12()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // Take while with index
            var result = numbers.TakeWhile((n, index) => n >= index);

            Console.WriteLine("First numbers not less than their position:");
            foreach (var n in result)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();
        }

        private static void Linq13()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // Skip while
            var result = numbers.SkipWhile(n => n % 3 != 0);

            Console.WriteLine("All elements starting from first element divisible by 3:");
            foreach (var n in result)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();
        }

        private static void Linq14()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // Skip while with index
            var result = numbers.SkipWhile((n, index) => n >= index);

            Console.WriteLine("All elements starting from first element less than its position:");
            foreach (var n in result)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();
        }

        private static void Linq15()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            // Order by
            var result =
                from word in words
                orderby word
                select word;

            // Alternate syntax
            var result2 = words.OrderBy(x => x);

            Console.WriteLine("The sorted list of words:");
            foreach (var w in result)
            {
                Console.WriteLine(w);
            }

            Console.ReadLine();
        }

        private static void Linq16()
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            // Order by then by
            var result =
                from digit in digits
                orderby digit.Length, digit
                select digit;

            // Alternate syntax
            digits.OrderBy(x => x.Length).ThenBy(x => x);

            Console.WriteLine("Sorted digits:");
            foreach (var d in result)
            {
                Console.WriteLine(d);
            }

            Console.ReadLine();
        }

        private static void Linq17()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // Group by
            var result =
                from num in numbers
                group num by num % 5 into numGroup
                select new { Remainder = numGroup.Key, Numbers = numGroup };

            // Alternate syntax
            var result2 = numbers.GroupBy(x => x % 5, y => y, (x, y) => new { Remainder = x, Numbers = y });

            foreach (var grp in result)
            {
                Console.WriteLine("Numbers with a remainder of {0} when divided by 5:", grp.Remainder);
                foreach (var n in grp.Numbers)
                {
                    Console.WriteLine(n);
                }
            }

            Console.ReadLine();
        }

        private static void Linq18()
        {
            string[] words = { "blueberry", "chimpanzee", "abacus", "banana", "apple", "cheese" };

            // Group by #2
            var result =
                from num in words
                group num by num[0] into grp
                select new { FirstLetter = grp.Key, Words = grp };

            // Alternate syntax
            var result2 = words.GroupBy(x => x[0], y => y).Select(g => new { FirstLetter = g.Key, Words = g });

            foreach (var wordgrp in result)
            {
                Console.WriteLine("Words that start with the letter '{0}':", wordgrp.FirstLetter);
                foreach (var word in wordgrp.Words)
                {
                    Console.WriteLine(word);
                }
            }

            Console.ReadLine();
        }

        private static void Linq19()
        {
            int[] factorsOf300 = { 2, 2, 3, 5, 5 };

            // Distinct
            var result = factorsOf300.Distinct();

            Console.WriteLine("Prime factors of 300:");
            foreach (var f in result)
            {
                Console.WriteLine(f);
            }

            Console.ReadLine();
        }

        private static void Linq20()
        {
            List<Product> products = GetProductList();

            // Distinct #2
            var result = (
                from prod in products
                select prod.Category)
                .Distinct();

            // Alternate syntax
            var result2 = products.Select(x => x.Category).Distinct();

            Console.WriteLine("Category names:");
            foreach (var n in result)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();
        }

        private static void Linq21()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            // Union
            var result = numbersA.Union(numbersB);

            Console.WriteLine("Unique numbers from both arrays:");
            foreach (var n in result)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();
        }

        private static void Linq22()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            // Intersect
            var result = numbersA.Intersect(numbersB);

            Console.WriteLine("Common numbers shared by both arrays:");
            foreach (var n in result)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();
        }

        private static void Linq23()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            // Except
            var result = numbersA.Except(numbersB);

            Console.WriteLine("Numbers in first array but not second array:");
            foreach (var n in result)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();
        }

        private static void Linq24()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            // List conversion
            var sortedWords =
                from w in words
                orderby w
                select w;
            var wordList = sortedWords.ToList();

            Console.WriteLine("The sorted word list:");
            foreach (var w in wordList)
            {
                Console.WriteLine(w);
            }

            Console.ReadLine();
        }

        private static void Linq25()
        {
            var scoreRecords = new[] 
            { 
                new {Name = "Alice", Score = 50},
                new {Name = "Bob"  , Score = 40},
                new {Name = "Cathy", Score = 45}
            };

            // Dictionary conversion
            var scoreRecordsDict = scoreRecords.ToDictionary(sr => sr.Name);

            Console.WriteLine("Bob's score: {0}", scoreRecordsDict["Bob"]);

            Console.ReadLine();
        }

        private static void Linq26()
        {
            string[] strings = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            // First
            string result = strings.First(s => s[0] == 'o');

            Console.WriteLine("A string starting with 'o': {0}", result);

            Console.ReadLine();
        }

        private static void Linq27()
        {
            // Range
            var numbers =
                from n in Enumerable.Range(100, 50)
                select new { Number = n, OddEven = n % 2 == 1 ? "odd" : "even" };

            // Alternate syntax
            var numbers2 = Enumerable.Range(100, 50).Select(x =>
                new { Number = x, OddEven = x % 2 == 1 ? "odd" : "even" });

            foreach (var n in numbers)
            {
                Console.WriteLine("The number {0} is {1}.", n.Number, n.OddEven);
            }

            Console.ReadLine();
        }

        private static void Linq28()
        {
            string[] words = { "believe", "relief", "receipt", "field" };

            // Any
            var result = words.Any(w => w.Contains("ei"));

            Console.WriteLine("There is a word in the list that contains 'ei': {0}", result);

            Console.ReadLine();
        }

        private static void Linq29()
        {
            int[] numbers = { 1, 11, 3, 19, 41, 65, 19 };

            // All
            var result = numbers.All(n => n % 2 == 1);

            Console.WriteLine("The list contains only odd numbers: {0}", result);

            Console.ReadLine();
        }

        private static void Linq30()
        {
            int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            // Count
            var result = numbers.Count(n => n % 2 == 1);

            Console.WriteLine("There are {0} odd numbers in the list.", result);

            Console.ReadLine();
        }

        private static void Linq31()
        {
            string[] words = { "cherry", "apple", "blueberry" };

            // Sum
            var sum = words.Sum(w => w.Length);
            Console.WriteLine("There are a total of {0} characters in these words.", sum);

            // Min
            var min = words.Min(x => x.Length);
            Console.WriteLine("The shortest word has {0} characters.", min);

            // Max
            var max = words.Max(x => x.Length);
            Console.WriteLine("The longest word has {0} characters.", max);

            // Average
            var avg = words.Average(x => x.Length);
            Console.WriteLine("The average length of the words is {0}.", avg);

            Console.ReadLine();
        }

        private static void Linq32()
        {
            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

            // Aggregate
            var result = doubles.Aggregate((runningProduct, nextFactor) => runningProduct * nextFactor);

            Console.WriteLine("Total product of all numbers: {0}", result);

            Console.ReadLine();
        }

        private static void Linq33()
        {
            double startBalance = 100.0;
            int[] attemptedWithdrawals = { 20, 10, 40, 50, 10, 70, 30 };

            // Aggregate #2
            var result =
                attemptedWithdrawals.Aggregate(startBalance,
                    (balance, nextWithdrawal) =>
                        ((nextWithdrawal <= balance) ? (balance - nextWithdrawal) : balance));

            Console.WriteLine("Ending balance: {0}", result);

            Console.ReadLine();
        }

        private static void Linq34()
        {
            int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            int[] numbersB = { 1, 3, 5, 7, 8 };

            // Concat
            var result = numbersA.Concat(numbersB);

            Console.WriteLine("All numbers from both arrays:");
            foreach (var n in result)
            {
                Console.WriteLine(n);
            }

            Console.ReadLine();
        }

        private static void Linq35()
        {
            string[] categories = new string[]{ 
                "Beverages", 
                "Condiments", 
                "Vegetables", 
                "Dairy Products", 
                "Seafood" };
            List<Product> products = GetProductList();

            // Join
            var result =
                from cat in categories
                join prod in products on cat equals prod.Category into ps
                from p in ps
                select new { Category = cat, p.ProductName };

            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName + ": " + item.Category);
            }

            Console.ReadLine();
        }

        private static void Linq36()
        {
            int[] numbers = { 1, 2, 3, 4 };
            string[] words = { "one", "two", "three" };

            // Zip #1
            var result = numbers.Zip(words, (first, second) => first + " " + second);

            Console.WriteLine("Combine two lists together:");
            foreach (var item in result)
                Console.WriteLine(item);
            Console.WriteLine();

            // Zip #2
            int[] numbers2 = { 5, 2, 1, 3, 6 };
            var result2 = numbers2.Zip(numbers, (first, second) => first > second ? first : second);

            Console.WriteLine("Select the highest number at each position:");
            foreach (var item in result2)
                Console.WriteLine(item);
            Console.WriteLine();

            // Zip #3
            double[] quarterlySales = { 4023.52, 7701.65, 2435.20 };
            double[] quarterlyRate = { 0.25, 0.2, 0.3, 0.2 };
            var result3 = quarterlySales.Zip(quarterlyRate, (first, second) => first * second).Sum();

            Console.WriteLine("Calculate total sales:");
            Console.WriteLine(result3);

            Console.ReadLine();
        }

        internal class Product
        {
            public int ProductID { get; set; }
            public string ProductName { get; set; }
            public string Category { get; set; }
            public decimal UnitPrice { get; set; }
            public int UnitsInStock { get; set; }
        }

        private static List<Product> productList;

        private static List<Product> GetProductList()
        {
            if (productList == null)
                CreateLists();

            return productList;
        }

        private static void CreateLists()
        {
            productList = new List<Product>()
            {
                    new Product { ProductID = 1, ProductName = "Chai", Category = "Beverages", UnitPrice = 18.0000M, UnitsInStock = 39 },
                    new Product { ProductID = 2, ProductName = "Chang", Category = "Beverages", UnitPrice = 19.0000M, UnitsInStock = 17 },
                    new Product { ProductID = 3, ProductName = "Aniseed Syrup", Category = "Condiments", UnitPrice = 10.0000M, UnitsInStock = 13 },
                    new Product { ProductID = 4, ProductName = "Chef Anton's Cajun Seasoning", Category = "Condiments", UnitPrice = 22.0000M, UnitsInStock = 53 },
                    new Product { ProductID = 5, ProductName = "Chef Anton's Gumbo Mix", Category = "Condiments", UnitPrice = 21.3500M, UnitsInStock = 0 },
                    new Product { ProductID = 6, ProductName = "Grandma's Boysenberry Spread", Category = "Condiments", UnitPrice = 25.0000M, UnitsInStock = 120 },
                    new Product { ProductID = 7, ProductName = "Uncle Bob's Organic Dried Pears", Category = "Produce", UnitPrice = 30.0000M, UnitsInStock = 15 },
                    new Product { ProductID = 8, ProductName = "Northwoods Cranberry Sauce", Category = "Condiments", UnitPrice = 40.0000M, UnitsInStock = 6 },
                    new Product { ProductID = 9, ProductName = "Mishi Kobe Niku", Category = "Meat/Poultry", UnitPrice = 97.0000M, UnitsInStock = 29 },
                    new Product { ProductID = 10, ProductName = "Ikura", Category = "Seafood", UnitPrice = 31.0000M, UnitsInStock = 31 },
                    new Product { ProductID = 11, ProductName = "Queso Cabrales", Category = "Dairy Products", UnitPrice = 21.0000M, UnitsInStock = 22 },
                    new Product { ProductID = 12, ProductName = "Queso Manchego La Pastora", Category = "Dairy Products", UnitPrice = 38.0000M, UnitsInStock = 86 },
                    new Product { ProductID = 13, ProductName = "Konbu", Category = "Seafood", UnitPrice = 6.0000M, UnitsInStock = 24 },
                    new Product { ProductID = 14, ProductName = "Tofu", Category = "Produce", UnitPrice = 23.2500M, UnitsInStock = 35 },
                    new Product { ProductID = 15, ProductName = "Genen Shouyu", Category = "Condiments", UnitPrice = 15.5000M, UnitsInStock = 39 },
                    new Product { ProductID = 16, ProductName = "Pavlova", Category = "Confections", UnitPrice = 17.4500M, UnitsInStock = 29 },
                    new Product { ProductID = 17, ProductName = "Alice Mutton", Category = "Meat/Poultry", UnitPrice = 39.0000M, UnitsInStock = 0 },
                    new Product { ProductID = 18, ProductName = "Carnarvon Tigers", Category = "Seafood", UnitPrice = 62.5000M, UnitsInStock = 42 },
                    new Product { ProductID = 19, ProductName = "Teatime Chocolate Biscuits", Category = "Confections", UnitPrice = 9.2000M, UnitsInStock = 25 },
                    new Product { ProductID = 20, ProductName = "Sir Rodney's Marmalade", Category = "Confections", UnitPrice = 81.0000M, UnitsInStock = 40 },
                    new Product { ProductID = 21, ProductName = "Sir Rodney's Scones", Category = "Confections", UnitPrice = 10.0000M, UnitsInStock = 3 },
                    new Product { ProductID = 22, ProductName = "Gustaf's Knäckebröd", Category = "Grains/Cereals", UnitPrice = 21.0000M, UnitsInStock = 104 },
                    new Product { ProductID = 23, ProductName = "Tunnbröd", Category = "Grains/Cereals", UnitPrice = 9.0000M, UnitsInStock = 61 },
                    new Product { ProductID = 24, ProductName = "Guaraná Fantástica", Category = "Beverages", UnitPrice = 4.5000M, UnitsInStock = 20 },
                    new Product { ProductID = 25, ProductName = "NuNuCa Nuß-Nougat-Creme", Category = "Confections", UnitPrice = 14.0000M, UnitsInStock = 76 },
                    new Product { ProductID = 26, ProductName = "Gumbär Gummibärchen", Category = "Confections", UnitPrice = 31.2300M, UnitsInStock = 15 },
                    new Product { ProductID = 27, ProductName = "Schoggi Schokolade", Category = "Confections", UnitPrice = 43.9000M, UnitsInStock = 49 },
                    new Product { ProductID = 28, ProductName = "Rössle Sauerkraut", Category = "Produce", UnitPrice = 45.6000M, UnitsInStock = 26 },
                    new Product { ProductID = 29, ProductName = "Thüringer Rostbratwurst", Category = "Meat/Poultry", UnitPrice = 123.7900M, UnitsInStock = 0 },
                    new Product { ProductID = 30, ProductName = "Nord-Ost Matjeshering", Category = "Seafood", UnitPrice = 25.8900M, UnitsInStock = 10 },
                    new Product { ProductID = 31, ProductName = "Gorgonzola Telino", Category = "Dairy Products", UnitPrice = 12.5000M, UnitsInStock = 0 },
                    new Product { ProductID = 32, ProductName = "Mascarpone Fabioli", Category = "Dairy Products", UnitPrice = 32.0000M, UnitsInStock = 9 },
                    new Product { ProductID = 33, ProductName = "Geitost", Category = "Dairy Products", UnitPrice = 2.5000M, UnitsInStock = 112 },
                    new Product { ProductID = 34, ProductName = "Sasquatch Ale", Category = "Beverages", UnitPrice = 14.0000M, UnitsInStock = 111 },
                    new Product { ProductID = 35, ProductName = "Steeleye Stout", Category = "Beverages", UnitPrice = 18.0000M, UnitsInStock = 20 },
                    new Product { ProductID = 36, ProductName = "Inlagd Sill", Category = "Seafood", UnitPrice = 19.0000M, UnitsInStock = 112 },
                    new Product { ProductID = 37, ProductName = "Gravad lax", Category = "Seafood", UnitPrice = 26.0000M, UnitsInStock = 11 },
                    new Product { ProductID = 38, ProductName = "Côte de Blaye", Category = "Beverages", UnitPrice = 263.5000M, UnitsInStock = 17 },
                    new Product { ProductID = 39, ProductName = "Chartreuse verte", Category = "Beverages", UnitPrice = 18.0000M, UnitsInStock = 69 },
                    new Product { ProductID = 40, ProductName = "Boston Crab Meat", Category = "Seafood", UnitPrice = 18.4000M, UnitsInStock = 123 },
                    new Product { ProductID = 41, ProductName = "Jack's New England Clam Chowder", Category = "Seafood", UnitPrice = 9.6500M, UnitsInStock = 85 },
                    new Product { ProductID = 42, ProductName = "Singaporean Hokkien Fried Mee", Category = "Grains/Cereals", UnitPrice = 14.0000M, UnitsInStock = 26 },
                    new Product { ProductID = 43, ProductName = "Ipoh Coffee", Category = "Beverages", UnitPrice = 46.0000M, UnitsInStock = 17 },
                    new Product { ProductID = 44, ProductName = "Gula Malacca", Category = "Condiments", UnitPrice = 19.4500M, UnitsInStock = 27 },
                    new Product { ProductID = 45, ProductName = "Rogede sild", Category = "Seafood", UnitPrice = 9.5000M, UnitsInStock = 5 },
                    new Product { ProductID = 46, ProductName = "Spegesild", Category = "Seafood", UnitPrice = 12.0000M, UnitsInStock = 95 },
                    new Product { ProductID = 47, ProductName = "Zaanse koeken", Category = "Confections", UnitPrice = 9.5000M, UnitsInStock = 36 },
                    new Product { ProductID = 48, ProductName = "Chocolade", Category = "Confections", UnitPrice = 12.7500M, UnitsInStock = 15 },
                    new Product { ProductID = 49, ProductName = "Maxilaku", Category = "Confections", UnitPrice = 20.0000M, UnitsInStock = 10 },
                    new Product { ProductID = 50, ProductName = "Valkoinen suklaa", Category = "Confections", UnitPrice = 16.2500M, UnitsInStock = 65 },
                    new Product { ProductID = 51, ProductName = "Manjimup Dried Apples", Category = "Produce", UnitPrice = 53.0000M, UnitsInStock = 20 },
                    new Product { ProductID = 52, ProductName = "Filo Mix", Category = "Grains/Cereals", UnitPrice = 7.0000M, UnitsInStock = 38 },
                    new Product { ProductID = 53, ProductName = "Perth Pasties", Category = "Meat/Poultry", UnitPrice = 32.8000M, UnitsInStock = 0 },
                    new Product { ProductID = 54, ProductName = "Tourtière", Category = "Meat/Poultry", UnitPrice = 7.4500M, UnitsInStock = 21 },
                    new Product { ProductID = 55, ProductName = "Pâté chinois", Category = "Meat/Poultry", UnitPrice = 24.0000M, UnitsInStock = 115 },
                    new Product { ProductID = 56, ProductName = "Gnocchi di nonna Alice", Category = "Grains/Cereals", UnitPrice = 38.0000M, UnitsInStock = 21 },
                    new Product { ProductID = 57, ProductName = "Ravioli Angelo", Category = "Grains/Cereals", UnitPrice = 19.5000M, UnitsInStock = 36 },
                    new Product { ProductID = 58, ProductName = "Escargots de Bourgogne", Category = "Seafood", UnitPrice = 13.2500M, UnitsInStock = 62 },
                    new Product { ProductID = 59, ProductName = "Raclette Courdavault", Category = "Dairy Products", UnitPrice = 55.0000M, UnitsInStock = 79 },
                    new Product { ProductID = 60, ProductName = "Camembert Pierrot", Category = "Dairy Products", UnitPrice = 34.0000M, UnitsInStock = 19 },
                    new Product { ProductID = 61, ProductName = "Sirop d'érable", Category = "Condiments", UnitPrice = 28.5000M, UnitsInStock = 113 },
                    new Product { ProductID = 62, ProductName = "Tarte au sucre", Category = "Confections", UnitPrice = 49.3000M, UnitsInStock = 17 },
                    new Product { ProductID = 63, ProductName = "Vegie-spread", Category = "Condiments", UnitPrice = 43.9000M, UnitsInStock = 24 },
                    new Product { ProductID = 64, ProductName = "Wimmers gute Semmelknödel", Category = "Grains/Cereals", UnitPrice = 33.2500M, UnitsInStock = 22 },
                    new Product { ProductID = 65, ProductName = "Louisiana Fiery Hot Pepper Sauce", Category = "Condiments", UnitPrice = 21.0500M, UnitsInStock = 76 },
                    new Product { ProductID = 66, ProductName = "Louisiana Hot Spiced Okra", Category = "Condiments", UnitPrice = 17.0000M, UnitsInStock = 4 },
                    new Product { ProductID = 67, ProductName = "Laughing Lumberjack Lager", Category = "Beverages", UnitPrice = 14.0000M, UnitsInStock = 52 },
                    new Product { ProductID = 68, ProductName = "Scottish Longbreads", Category = "Confections", UnitPrice = 12.5000M, UnitsInStock = 6 },
                    new Product { ProductID = 69, ProductName = "Gudbrandsdalsost", Category = "Dairy Products", UnitPrice = 36.0000M, UnitsInStock = 26 },
                    new Product { ProductID = 70, ProductName = "Outback Lager", Category = "Beverages", UnitPrice = 15.0000M, UnitsInStock = 15 },
                    new Product { ProductID = 71, ProductName = "Flotemysost", Category = "Dairy Products", UnitPrice = 21.5000M, UnitsInStock = 26 },
                    new Product { ProductID = 72, ProductName = "Mozzarella di Giovanni", Category = "Dairy Products", UnitPrice = 34.8000M, UnitsInStock = 14 },
                    new Product { ProductID = 73, ProductName = "Röd Kaviar", Category = "Seafood", UnitPrice = 15.0000M, UnitsInStock = 101 },
                    new Product { ProductID = 74, ProductName = "Longlife Tofu", Category = "Produce", UnitPrice = 10.0000M, UnitsInStock = 4 },
                    new Product { ProductID = 75, ProductName = "Rhönbräu Klosterbier", Category = "Beverages", UnitPrice = 7.7500M, UnitsInStock = 125 },
                    new Product { ProductID = 76, ProductName = "Lakkalikööri", Category = "Beverages", UnitPrice = 18.0000M, UnitsInStock = 57 },
                    new Product { ProductID = 77, ProductName = "Original Frankfurter grüne Soße", Category = "Condiments", UnitPrice = 13.0000M, UnitsInStock = 32 }
            };
        }
    }
}

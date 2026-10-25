using LINQ.Models;                       // Product (Q15, Q17)
using static LINQ.DataSources.Source;    // ProductList, CustomerList

namespace LINQ
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// [Q1] Top 3 most expensive products
			//Console.WriteLine("--- Q1 ---");
			//var q1 = ProductList.OrderByDescending(p => p.UnitPrice).Take(3);
			//foreach (var p in q1)
			//	Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");

			// [Q2] Page 2, page size 5  => Skip((page-1)*size).Take(size)
			//Console.WriteLine("--- Q2 ---");
			//int pageNumber = 2, pageSize = 5;
			//var q2 = ProductList.Skip((pageNumber - 1) * pageSize).Take(pageSize);
			//foreach (var p in q2)
			//	Console.WriteLine(p.ProductName);


			// [Q3] TakeWhile price < 25 (MUST be ordered by price first)
			//Console.WriteLine("--- Q3 ---");
			//var q3 = ProductList.OrderBy(p => p.UnitPrice).TakeWhile(p => p.UnitPrice < 25);
			//foreach (var p in q3)
			//	Console.WriteLine($"{p.ProductName} - {p.UnitPrice}");



			// [Q4] Are ALL Seafood products in stock?
			//Console.WriteLine("--- Q4 ---");
			//bool q4 = ProductList.Where(p => p.Category == "Seafood").All(p => p.UnitsInStock > 0);
			//Console.WriteLine($"All seafood in stock? {q4}");



			// [Q5] Does ids contain 9?
			//Console.WriteLine("--- Q5 ---");
			//int[] ids = { 3, 9, 13, 18 };
			//Console.WriteLine($"Contains 9? {ids.Contains(9)}");



			// [Q6] Group by Category + count
			//Console.WriteLine("--- Q6 ---");
			//var q6 = ProductList.GroupBy(p => p.Category);
			//foreach (var g in q6)
			//	Console.WriteLine($"{g.Key} -> {g.Count()} products");



			// [Q7] Group by Category, project only names per group
			//Console.WriteLine("--- Q7 ---");
			//var q7 = ProductList.GroupBy(p => p.Category)
			//					.Select(g => new { Category = g.Key, Names = g.Select(p => p.ProductName) });
			//foreach (var g in q7)
			//{
			//	Console.WriteLine(g.Category);
			//	foreach (var n in g.Names)
			//		Console.WriteLine($"   {n}");
			//}



			// [Q8] Categories with MORE THAN 3 products
			//Console.WriteLine("--- Q8 ---");
			//var q8 = ProductList.GroupBy(p => p.Category)
			//					.Where(g => g.Count() > 3)
			//					.Select(g => g.Key);
			//foreach (var c in q8)
			//	Console.WriteLine(c);



			// [Q9] QUERY SYNTAX: group customers by Country -> { Country, Count, TotalOrderValue }
			//Console.WriteLine("--- Q9 ---");
			//var q9 =
			//	from c in CustomerList
			//	group c by c.Country into g
			//	select new
			//	{
			//		Country = g.Key,
			//		Count = g.Count(),
			//		TotalOrderValue = g.Sum(c => c.Orders.Sum(o => o.Total))
			//	};
			//foreach (var x in q9)
			//	Console.WriteLine($"{x.Country} | {x.Count} | {x.TotalOrderValue:C2}");



			// [Q10] Total units in stock
			//Console.WriteLine("--- Q10 ---");
			//Console.WriteLine($"Total units in stock: {ProductList.Sum(p => p.UnitsInStock)}");





			// [Q11] Cheapest and most expensive prices
			//Console.WriteLine("--- Q11 ---");
			//Console.WriteLine($"Cheapest: {ProductList.Min(p => p.UnitPrice)}, " +
			//				  $"Most expensive: {ProductList.Max(p => p.UnitPrice)}");



			// [Q12] Distinct categories
			//Console.WriteLine("--- Q12 ---");
			//var q12 = ProductList.Select(p => p.Category).Distinct();
			//foreach (var c in q12)
			//	Console.WriteLine(c);



			// [Q13] IDs in setA but NOT in setB  (set difference)
			//Console.WriteLine("--- Q13 ---");
			//int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
			//int[] setB = { 3, 6, 9, 12, 15, 13 };
			//Console.WriteLine(string.Join(", ", setA.Except(setB)));   // 1, 5, 7, 11


			// [Q14] Countries in list1 but NOT in list2 (case-insensitive)
			//Console.WriteLine("--- Q14 ---");
			//string[] list1 = { "Germany", "France", "UK", "Spain" };
			//string[] list2 = { "france", "SPAIN", "Italy" };
			//Console.WriteLine(string.Join(", ", list1.Except(list2, StringComparer.OrdinalIgnoreCase)));   // Germany, UK


			// [Q15] Dictionary<int, Product> keyed by ProductID, print ID = 18
			//Console.WriteLine("--- Q15 ---");
			//Dictionary<int, Product> dict = ProductList.ToDictionary(p => p.ProductID);
			//Console.WriteLine(dict[18]);



			// [Q16] First product with price > 50 (First throws if none match)
			//Console.WriteLine("--- Q16 ---");
			//Console.WriteLine(ProductList.First(p => p.UnitPrice > 50));


		}
	}
}
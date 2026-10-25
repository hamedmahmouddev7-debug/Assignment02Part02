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
		}
	}
}
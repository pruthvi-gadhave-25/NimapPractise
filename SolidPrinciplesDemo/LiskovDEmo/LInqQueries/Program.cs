using System;

namespace LInqQueries
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinqList.LinqDemo1();
            LinqList.LinqDemo2();
            Console.WriteLine("\nPagination\n");
            LinqList.PaginationDemo(2, 5);
        }
    }
}
//When should you use LINQ Method Syntax (Fluent Syntax)?
//-> 1.complex queries, especially those involving multiple operations.
//2. operations requires 
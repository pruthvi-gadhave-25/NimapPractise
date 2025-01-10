using System;

namespace DateTimeDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var date = new DateTime(2025, 2, 3);
            //Console.WriteLine(date.ToString());

            var now = DateTime.Now;
            Console.WriteLine(now);

            Console.WriteLine($"Hour  : {now.Hour}");
            Console.WriteLine($"Day  : {now.Day}");
            Console.WriteLine($"MIn  : {now.Minute}");
            Console.WriteLine($"Date  : {now.Date.ToString("dd/MM/yy")}");

            //TimeSpan 

            var timespan = new TimeSpan(1, 2, 2);
            Console.WriteLine(timespan);
            var timespan1 = TimeSpan.FromHours(2);
            Console.WriteLine(timespan1);


            var start = DateTime.Now;
            var end = DateTime.Now.AddMinutes(2);
            Console.WriteLine(end-start);
            dynamic num = 122;
            string n = num;
            Console.WriteLine(n);

            object obj = 45;
            string str = obj;

            string s = "ewid";

            object ob = s; // runtime error 
            //int b =(int)ob;
        }
    }
}

using System;
using System.Collections.Generic;
namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var list = new List<string> { "W", "W", "W", "W", "W", "W", "W", "W", "W", "W", "B", "B", "B",
            "B", "B", "B", "B", "B", "R", "R"};
            int index = rnd.Next(list.Count);
            list.OrderBy(x => rnd.Next()).Take(2);
            //if (object1 == list.Count)
            //{

            //}
            Console.WriteLine(list[index]);
        }
    }
}

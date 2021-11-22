using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>();
            num.Add(2);
            num.Add(3);
            Console.WriteLine(num.Count);
            List<int> num2 = new List<int>()
            {
                5,3,2
            };
            Console.WriteLine(num2.Count);
            num2.Add(0);
            Console.WriteLine(num2.Count);

            num2.Clear();
            Console.WriteLine(num2.Count);

            List<string> country = new List<string>()
            {
                "colombia","mexico"
            };
            Console.WriteLine(country.Count);

        }
    }
}

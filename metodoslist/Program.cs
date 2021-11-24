using System;
using System.Collections.Generic;

namespace metodoslist
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> n = new List<int>()
            {
                2,2,3,3
            };

            show(n);
            //insert
            n.Insert(0, 5);
            show(n);
            //contains
            if(n.Contains(5))
                Console.WriteLine("existe");
            else
                Console.WriteLine("no existe");

            //indexof
            int pos = n.IndexOf(2);
            Console.WriteLine(pos);

            //sort
            n.Sort();
            show(n);

            //add range

            var n2 = new List<int>()
            {
                455,434,213
            };

            n.AddRange(n2);
            show(n);
        }
        public static void show(List<int> number)
        {
            Console.WriteLine("----------Numbers-------");
            foreach(var n in number)
            {
                Console.WriteLine(n);
            }
        }
    }
}

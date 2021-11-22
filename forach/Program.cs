using System;
using System.Collections.Generic;

namespace forach
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>()
            {
                5,4,5,1,2,8,9,0,12
            };

            var people = new List<People>()
            {
                new People(){name="oscar",country="usa"},
                new People(){name="Daniel",country="mexico"}
            };

            show(people);
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            };


            
        }
        static void show(List<People> students)
        {
            Console.WriteLine("-----students ----------");
            foreach(var p in students)
            {
                Console.WriteLine($"Nombre:{p.name}, country:{p.country} ");
            }
        }

    }

    public class People
    {
        public string name { get; set; }
        public string country { get; set; }
    }
}

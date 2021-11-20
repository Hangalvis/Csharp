using System;

namespace Static
{
    class Program
    {
        static void Main(string[] args)
        {
            People p = new People()
            {
                name="Julia",
                age=22
            };

            People h = new People()
            {
                name = "Julia",
                age = 22
            };

            Console.WriteLine(People.getcount());
        }

        public class People
        {
            public static int count = 0;
            public string name { get; set; }
            public int age { get; set; }

            public People()
            {
                count++;
            }

            public static string getcount()
            {
                return $"la clase se utilizado {count} veces";
            }
        }
    }
}

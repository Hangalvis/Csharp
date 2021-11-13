using System;

namespace Arreglos
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friends = new string[5]{
                "sebastian",
                "carlos",
                "andres",
                "felipe",
                null
            };
            friends[0] = "Han";
            System.Console.WriteLine(friends[0]);
            Console.WriteLine(friends[1]);
        }
    }
}

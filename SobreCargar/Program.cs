using System;

namespace SobreCargar
{
    class Program
    {
        static void Main(string[] args)
        {
            Math math = new Math();
            Console.WriteLine(math.sum(5,5));
            Console.WriteLine(math.sum("2","3"));
            int[] numbers = new int[]
            {
                5,2,7
            };
            Console.WriteLine(math.sum(numbers));
        }
    }

    class Math
    {
        public int sum(int a,int b)
        {
            return a + b;
        }

        public int sum(string a,string b)
        {
            return int.Parse(a) + int.Parse(b);
        }

        public int sum(int[] numbers)
        {
            int result = 0;
            int i = 0;
            while (i < numbers.Length)
            {
                result += numbers[i];
                i++;
            }
            return result;
        }
    }
}

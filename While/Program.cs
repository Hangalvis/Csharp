using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;

            while (i < 10)
            {
                Console.WriteLine("1 iteracion {0}",i);
                i++;
            }

            int j = 0;
            while (j < 100)
            {
                if (j == 10)
                    break;
                Console.WriteLine("2 iteracion {0}",j);
                j++;
            }

            string[] nombres = new string[5]
            {
                "jose",
                "andrea",
                "carlos",
                "jisel",
                "andres"
            };

            int index = 0;

            while(index < nombres.Length)
            {
                Console.WriteLine(nombres[index]);
                index++;
            }

            bool run = false;
            do
            {
                Console.WriteLine("entra una vez");
            } while (run);
        }



    }
}

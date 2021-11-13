using System;

namespace For
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nom = new string[5]
            {
                "camilo",
                "brayan",
                "oscar",
                "edwar",
                "pacho"
            };

            for (int i=0;i<nom.Length;i++)
            {
                Console.WriteLine(nom[i]);
            }

        }
    }
}

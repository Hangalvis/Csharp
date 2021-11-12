using System;

namespace Condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad = 18;
            if (edad >= 18)
            {
                Console.WriteLine("puedes ingresar");
            }
            else
            {
                Console.WriteLine("no puedes ingresar");
            }

            char nota = 'C';

            switch (nota)
            {
                case 'A':
                    Console.WriteLine("Nota superior");
                    break;
                case 'B':
                    Console.WriteLine("Nota Intermedia");
                    break;
                case 'C':
                    Console.WriteLine("nota baja");
                    break;
                default:
                    Console.WriteLine("Dato ingresado no valido");
                    break;
            }

        }
    }
}

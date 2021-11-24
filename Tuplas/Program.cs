using System;

namespace Tuplas
{
    class Program
    {
        static void Main(string[] args)
        {
            (int id, string descripcion) product = (1, "laptop");
            Console.WriteLine($" {product.id}  {product.descripcion}");
            product.id = 2;
            Console.WriteLine($" {product.id}  {product.descripcion}");

            var people = (24, "galvis");
            Console.WriteLine($"{people.Item1} {people.Item2}");

            var person = new[]
            {
                ("jose","garzon"),
                ("andres","guitierrez")
            };

            foreach(var p in person)
            {
                Console.WriteLine($"{p.Item1} {p.Item2}");
            }

            obtenerdatos();
            Console.WriteLine(obtenerdatos());
            var info = obtenerdatos();
            Console.WriteLine($"obteniendo los datos de la tupla {info.a}  {info.b}  {info.dato} ");
            var (_, b,_) = obtenerdatos();
            Console.WriteLine(b);

        }

        public static(float a,float b,string dato) obtenerdatos()
        {
            float a = 123f;
            float b = 4234.5f;
            string dato = "hola";
            return (a, b, dato);
        }
    }
}

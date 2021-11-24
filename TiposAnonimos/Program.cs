using System;

namespace TiposAnonimos
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new
            {
                name="jose",
                lastname="hernandez"
            };

            Console.WriteLine($"{names.name} {names.lastname}");
            //names.lastname = "dsd"; //NO

            var animal = new[]{
                new {name="perro",tipo="mascota"},
                new {name="leon",tipo="salvaje"}
            };

            foreach(var a in animal)
            {
                Console.WriteLine($"{a.name} {a.tipo}");
            }
        }
    }
}

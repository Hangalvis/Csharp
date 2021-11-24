using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Persona> p = new List<Persona>()
            {
                new Persona
                {
                    name="oscar",country="colombia"
                },
                new Persona
                {
                    name="julieth",country="españa"
                },
                new Persona
                {
                    name="nadia",country="chile"
                }
            };


            foreach(var per in p)
            {
                Console.WriteLine(per);
            }


            Console.WriteLine( "--------------------------");
            //---------SELECT
            var peoplename = from b in p
                             select new
                             {
                                 Name = b.name,
                                 lettername=b.name.Length,
                                 Fixed=1
                             };

            foreach(var r in peoplename)
            {
                Console.WriteLine($"{r.Name} {r.lettername} {r.Fixed}");
            }

            Console.WriteLine("------------------------------");
            var peoplenameral = from b in peoplename
                                select new
                                {
                                    name = b.Name
                                };
            foreach(var p1 in peoplenameral)
                Console.WriteLine($"{p1.name}");


            Console.WriteLine("-------------WHERE-----------");
            var peopleconuntry = from b in p
                                 where b.country == "colombia" || b.country=="chile"  select b;

            foreach(var re in peopleconuntry)
                Console.WriteLine(re);


            Console.WriteLine("-------------order-----------");
            var peopleorder = from b in p
                                 orderby b.country //descending
                                 select b;

            foreach (var re in peopleorder)
                Console.WriteLine(re);



        }
    }


    public class Persona
    {
        public string name { get; set; }
        public string country { get; set; }

        public override string ToString()
        {
            return $" Nombre :{name} Pais: {country}";
        }
    }
}

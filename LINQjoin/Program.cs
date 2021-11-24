using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQjoin
{
    class Program
    {
        static void Main(string[] args)
        {

            List<People> p = new List<People>()
            {
                new People()
                {
                    name="luis",
                    country="colombia"
                },
                new People()
                {
                    name="carlos",
                    country="japon"
                },
                new People()
                {
                    name="manolo",
                    country="españa"
                }
            };

            List<countries> c = new List<countries>()
            {
                new countries()
                {
                    name="españa",
                    continet="europa"
                },
                new countries()
                {
                    name="colombia",
                    continet="sur america"
                },
                new countries()
                {
                    name="japon",
                    continet="asia"
                }
            };


            Console.WriteLine("---------------");

            var peoplewithcountry = from people in p
                                    join countri in c
                                    on people.country equals countri.name
                                    select new
                                    {
                                        name = people.name,
                                        country= people.country,
                                        continect= countri.continet
                                    };
            foreach(var data in peoplewithcountry)
                Console.WriteLine($"{data.name} {data.country} {data.continect}");
        }
    }

    public class People
    {
        public string name { get; set; }
        public string country { get; set; }
    }

    public class countries
    {
        public string name { get; set; }
        public string continet { get; set; }
    }
}

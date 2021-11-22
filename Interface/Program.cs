using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Shark[] s = new Shark[]
            {
                new Shark("tiburon 1",56),
                new Shark("tiburon 2",76.4m)
            };

            showfish(s);
            showAnimal(s);
        }

        public static void showAnimal(Ianimal[] animal)
        {
            Console.WriteLine("------mostrando animal --------");
            int i = 0;
            while (i < animal.Length)
            {
                Console.WriteLine(animal[i].Name);
                i++;
            }
        }

        public static void showfish(Ifish[] fishes)
        {
            Console.WriteLine("------mostrando peces --------");
            int i = 0;
            while (i<fishes.Length)
            {
                Console.WriteLine(fishes[i].swim());
                i++;
            }
        }
    }

    public class Shark : Ianimal, Ifish
    {
        public string Name { get; set; }
        public decimal Speed { get; set; }
        
        public Shark(string Name, decimal Speed)
        {
            this.Name = Name;
            this.Speed = Speed;
        }
        public string swim()
        {
            return $"Animal {Name} con una velocidad {Speed} de km/h";
        }

    }
    public interface Ianimal
    {
        public string Name { get; set; }
    }

    public interface Ifish
    {
        public decimal Speed { get; set; }

        public string swim();
    } 
}

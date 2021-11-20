using System;

namespace SobreEscritura
{
    class Program
    {
        static void Main(string[] args)
        {
            B b = new B();
            Console.WriteLine(b.Hi());
        }
    }

    public class A
    {
        public virtual string Hi()
        {
            return "Hola soy A ";
        }
    }

    public class B : A
    {
        public override string Hi()
        {
            return base.Hi()+"hola soy B";
            // return "Hola soy B";

        }
    }
}

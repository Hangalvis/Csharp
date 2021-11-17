using System;

namespace ClasesObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            sale sale1 = new sale(250,DateTime.Now);
            sale1.show();
            Console.WriteLine(sale1.getinfo());
            sale sale2 = new sale(500, DateTime.Now);
            Console.WriteLine(sale2.getinfo());
        }
    }

    class sale
    {
        int total;
        DateTime fecha;

        //constructor
        public sale(int total,DateTime fecha)
        {
            this.total = total;
            this.fecha = fecha;
        } 

        public string getinfo()
        {
            return total + " " + fecha.ToLongDateString();
        }
        public void show()
        {
            Console.WriteLine("hola soy una venta");
        }
    }
}

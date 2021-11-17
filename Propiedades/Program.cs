using System;

namespace Propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            sale sale1 = new sale(250, DateTime.Now);
            sale1.Total = -54;
            Console.WriteLine(sale1.Total);
            sale1.Total = 25;
            Console.WriteLine(sale1.Total);
            Console.WriteLine(sale1.Date);
        }
    }

    class sale
    {
        private int total;
        private DateTime fecha;

        public string Date
        {
            get
            {
                return fecha.ToLongDateString();
            }
        }

        public int Total
        {
            get
            {
                return total;
            }
            set
            {
                if (value < 0)
                    value = 0;
                total = value;
            }
        }

        //constructor
        public sale(int total, DateTime fecha)
        {
            this.total = total;
            this.fecha = fecha;
        }
    }
}

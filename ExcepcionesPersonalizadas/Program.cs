using System;

namespace ExcepcionesPersonalizadas
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                People p = new People()
                {
                    name = "oscar",
                   // age = "45"
                };

                Console.WriteLine(p);
            }
            //catch(Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}
            catch (excepcionpeople ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {

            }



        }
    }
    public class excepcionpeople : Exception
    {
        public excepcionpeople():base("no tiene nombre o edad")
        {

        }
    }

    public class People
    {
        public string name { get; set; }
        public string age { get; set; }

        public override string ToString()
        {
            if (name == null || age == null)
                //throw new Exception();
                throw new excepcionpeople();
            return $"{name} {age}";
        }
    }
}

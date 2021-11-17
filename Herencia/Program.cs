using System;

namespace Herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Doctor d = new Doctor("Han g", 23, "Cardiologo");
            Console.WriteLine(d.getinfo());
            Console.WriteLine(d.getdata());

            Dev Dev = new Dev("Oscar", 30, "c#");
            Console.WriteLine(Dev.getinfo());
            Console.WriteLine(Dev.getdev());
        }
    }

    class People
    {
        private string _name;
        private int _age;

        public People(string name,int age)
        {
            _name = name;
            _age = age;
        }

        public string getinfo()
        {
            return "Nombre: " + _name + " Edad: " + _age;
        }

    }

    class Doctor:People
    {
        private string _speciality;
        public Doctor(string name,int age,string speciality) : base(name, age)
        {
            _speciality = speciality;
        }

        public string getdata()
        {
            return getinfo() + " Especialida: " + _speciality;
        }
    }


    class Dev : People
    {
        private string _lenguage;
        public Dev(string  name,int age,string lenguage) : base(name, age)
        {
            _lenguage = lenguage;
        }

        public string getdev()
        {
            return getinfo() + " Lenguaje: " + _lenguage;
        }
    }
}

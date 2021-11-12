using System;

namespace Funciones
{
    class Program
    {
        static void Main(string[] args)
        {
            Mensaje();
            sum(10,5);
            string nom = nombreusu("smith");
            System.Console.WriteLine(nom);
        }

        static void Mensaje(){
            System.Console.WriteLine("Funcion que se imprime");
        }

        static void sum(int num1,int num2){
            int rta=num1+num2;
            System.Console.WriteLine("la suma es {0} + {1} ={2}",num1,num2,rta);
        }

        static string nombreusu(string nombre){
            return "Nombre: "+nombre;
        }

    }
}

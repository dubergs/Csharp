using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerProjecto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingresa primer numero: ");
            //Convertir tipo de dato directamente desde el input 
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingresar segundo numero: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("La suma es: " + (num1 + num2));
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¡Calculadora de Cuatro Funciones!");
            Console.ReadLine();


            Console.Write("Ingresa el primer numero: ");
            double numero1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Ingresa el segundo numero: ");
            double numero2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("sumar, restar, multiplicar, dividir");
            Console.Write("Que operacion deseas hacer?: ");
            string operador = Console.ReadLine();

            if (operador == "sumar")
            {
                Console.WriteLine("El resultado de la suma es: " + (numero1 + numero2));
                Console.ReadLine();
            }
            else if(operador == "restar")
            {
                Console.WriteLine("El resultado de la resta es: " + (numero1 - numero2));
                Console.ReadLine();
            }
            else if(operador == "multiplicar")
            {
                Console.WriteLine("El resultado de la multiplicacion es: " + (numero1 * numero2));
                Console.ReadLine();
            }
            else if(operador == "dividir")
            {
                Console.WriteLine("El resultado de la division es: " + (numero1 / numero2));
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Lo siento no contamos con esta operacion");
                Console.ReadLine();
            }
        }
    }
}

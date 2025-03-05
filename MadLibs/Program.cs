using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {

            //Matrices
            int[] MisNumeros = { 1, 2, 3, 4, 5 };
            string[] Paises = { "Colombia", "Panama", "Venezuela" };

            Console.WriteLine("La lista contiene los siguientes numeros: " + Paises[0]);
            Console.ReadLine();


            //MadLibs
            string color, comida, pais;
            Console.WriteLine("Ingresa el color");
            color = Console.ReadLine();

            Console.WriteLine("Ingresa la comida");
            comida = Console.ReadLine();

            Console.WriteLine("Ingresa el pais");
            pais = Console.ReadLine();

            Console.WriteLine("Mi color favorito es " + color);
            Console.WriteLine("Mi comida favorita es " + comida);
            Console.WriteLine("Mi pais favorito es " + pais);

            Console.ReadLine();
        }
    }
}

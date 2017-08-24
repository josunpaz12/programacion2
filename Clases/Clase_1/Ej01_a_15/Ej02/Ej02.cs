using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej02
{
    class Ej02
    {
        static void Main(string[] args)
        {
            int numero;
            double cuadrado;
            double cubo;

            Console.WriteLine("Ingrese un numero:");
            numero = int.Parse(Console.ReadLine());

            cuadrado = Math.Pow(numero, 2);
            cubo = Math.Pow(numero, 3);

            Console.WriteLine("\nEl cuadrado de {0} es {1}.\nEl cubo de {0} es {2}.\n", numero, cuadrado, cubo);

            Console.ReadKey();


        }
    }
}

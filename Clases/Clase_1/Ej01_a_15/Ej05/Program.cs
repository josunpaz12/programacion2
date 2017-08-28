using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej05
{
    class Program
    {
        static void Main(string[] args)
        {
            bool validarNumero = false;
            int numero = 0,
                i;
                
            
            Console.WriteLine("-------------Centro Numerico-------------\n\n");

            while (!validarNumero || numero < 1)
            {
                Console.WriteLine("Ingrese un numero positivo:");
                validarNumero = int.TryParse(Console.ReadLine(),out numero);
            }
            for (i = 1; i <= numero; i++)
            { 
                
            
            }



            Console.ReadKey();

        }
    }
}

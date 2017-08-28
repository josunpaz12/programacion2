using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej03
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nprimos= new int [20];
            bool validarNumero=false;
            int numero = 0,
                contador= 0,
                resto,
                i,
                j;
            
            while(!validarNumero)
            {
            Console.WriteLine("Ingrese un numero:");
            validarNumero = int.TryParse(Console.ReadLine(),out numero);
            }

            if(numero<2)
                Console.WriteLine("Los Numeros primos son:");

            for (i = 1; i <= numero; i++)
            {
                for ( j = 1; j < i; j++)
                {
                    if ((resto = i % j) == 0)
                        contador++;      
                }

                if (contador == 1)
                    Console.WriteLine("{0} - ", i);

                contador = 0;
            }


            Console.ReadKey();
        }
    }
}

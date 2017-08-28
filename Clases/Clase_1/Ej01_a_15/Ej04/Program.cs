using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej04
{
    class Program
    {
        static void Main(string[] args)
        {
            int contador = 0,
                acumulador = 0,
                resto,
                i=1,
                j;


            Console.WriteLine("Mostrar: Primeros 4 numeros perfectos.");

            while (contador < 4)
            {
                for (j = 1; j <= i; j++)
                { 
                    if((resto=i%j)==0)
                        acumulador = acumulador + j;
                }

                if ((acumulador - i) == i)
                {
                    Console.WriteLine("Numero perfecto:{0}\n", i);
                    contador++;
                }
                acumulador = 0;
                i++;
            }

            Console.ReadKey();
        }
    }
}

                                using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Ej01
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5];
            int mayor=0,
                menor=0,
                acumulador=0,
                promedio=0,
                i;

                for (i = 0; i < 5; i++)
                {
                    Console.WriteLine("Ingrese el numero {0}:",i+1);
                    numeros[i] = int.Parse(Console.ReadLine());

                    if (i == 0)
                    {
                        mayor = numeros[i];
                        menor = numeros[i];

                    }

                    if (mayor < numeros[i])
                        mayor = numeros[i];

                    if (menor > numeros[i])
                        menor = numeros[i];

                    acumulador = acumulador + numeros[i];
                }

                promedio = acumulador / 5;

                Console.WriteLine("\nEl numero mayor es:{0}\nEl numero menor es:{1}\nEl promedio es:{2}\n",mayor,menor,promedio);

                Console.ReadKey();

        }
    }
}

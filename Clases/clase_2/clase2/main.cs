using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase2
{
    class main
    {
        static void Main(string[] args)
        {
            int i;
            bool flag = true;
            bool validarSoloNumeros = false;

            int numero = 0;
            int menor = 0;
            int mayor= 0;
            int promedio=0;



            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Ingrese el numero {0}/10:", i+1);
                validarSoloNumeros = int.TryParse(Console.ReadLine(),out numero);

                while(!(Validacion.Validar(-100, 100, numero) && validarSoloNumeros))
                {
                    Console.WriteLine("Reingrese el numero {0}/10:", i+1);
                    validarSoloNumeros = int.TryParse(Console.ReadLine(),out numero);
                }

                if (flag)
                {
                    menor = numero;
                    mayor = numero;
                    flag = false;
                }
                
                if(menor>numero)
                    menor=numero;

                if(mayor<numero)
                    mayor=numero;

                promedio=promedio+numero;
            }

            promedio=promedio/10;

            Console.WriteLine("El numero maximo es:{0}.\nEl numero minimo es:{1}.\nEl promedio es:{2}.", mayor, menor, promedio);

            Console.ReadKey();

        }
    }
}

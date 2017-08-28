using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej13
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero=0;
            int opcion=0;
            bool validarNumero = false;
            string resultadoDecimal;


            while (!validarNumero || opcion < 1 || opcion > 2)
            {
                Console.WriteLine("Bienvenido\n\n1-Convertir decimal a binario\n2-Convertir binario a decimal.\n\nSeleccione una opcion:");
                validarNumero = int.TryParse(Console.ReadLine(), out opcion);
                Console.Clear();
            }

            validarNumero = false;


            while (!validarNumero && opcion==1)
            {
                Console.WriteLine("Ingrese un numero:");
                validarNumero = int.TryParse(Console.ReadLine(),out numero);
            }
            resultadoDecimal=conversor.DecimalBinario(numero);

            Console.WriteLine("El numero en binario tiene el siguiente valor:{0}",resultadoDecimal);

            Console.ReadKey();
        }
    }
}

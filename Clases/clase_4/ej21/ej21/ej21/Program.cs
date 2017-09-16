using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dinero;

namespace ej21
{
    class Program
    {
        static void Main(string[] args)
        {
            double valorDolar = 17.16,
                    valorEuro = 20.75,
                    cantEuros = 0,
                    cantDolares=0;
            int opc = 0;

            Console.WriteLine("1-Convertir UDS en Euros.\n2-Convertir Euros en USD.\n\nSeleccionar Opcion:");
           while(!int.TryParse(Console.ReadLine(),out opc) || opc <1 || opc>2)
           { Console.WriteLine("No ingreso un valor valido, reingrese opcion:"); }

           Console.Clear();
           if (opc == 1)
           {
               Console.WriteLine("**--Convertir UDS en Euros--**\t\t\t*Valor euro:{0} *Valor dolar:{1}\n\n",valorDolar, valorEuro);
               Console.WriteLine("Ingrese el monto a convertir:");
               while (!double.TryParse(Console.ReadLine(), out cantDolares))
               { Console.WriteLine("No ingreso un valor valido, reingrese valor:"); }
               Dolar objetoDolar = new Dolar(cantDolares,valorDolar);


               Console.ReadKey();

           }

           Console.Clear();
           if (opc == 2)
           {
               Console.WriteLine("**--Convertir Euros en USD--**\t\t\t*Valor euro:{0} *Valor dolar:{1}\n\n", valorDolar, valorEuro);
               Console.WriteLine("Ingrese el monto a convertir:");
               while (!double.TryParse(Console.ReadLine(), out cantEuros))
               { Console.WriteLine("No ingreso un valor valido, reingrese valor:"); }
               Euro objetoEuro = new Euro(cantEuros, valorEuro);
               


               Console.ReadKey();
           }

           Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using distinto;

namespace ej19
{
    class Program
    {
        static void Main(string[] args)
        {
            int CantBoliAzulInicial = 100,
                CantBoliRojaInicial = 50,
                CantAzulActual,
                CantRojoActual;
            ConsoleColor azul = ConsoleColor.Blue,
                rojo = ConsoleColor.Red;

            bool pudoPintar = false;

            Boligrafo boliAzul = new Boligrafo (azul,CantBoliAzulInicial);
            Boligrafo boliRoja = new Boligrafo(rojo, CantBoliRojaInicial);


            CantAzulActual = boliAzul.getTinta();
            CantRojoActual = boliRoja.getTinta();


            Console.WriteLine("Cantidad boli {0} actual:{1}", azul,CantAzulActual);
            Console.WriteLine("Cantidad boli {0} actual:{1}\n\n", rojo,CantRojoActual);


            pudoPintar=boliAzul.Pintar(20);
            if (pudoPintar)
                Console.WriteLine("\nPudo Pintar Azul {0}\n",20);

            pudoPintar = false;
            pudoPintar=boliRoja.Pintar(15);
            if (pudoPintar)
                Console.WriteLine("\nPudo Pintar Rojo {0}\n",15);

            CantAzulActual = boliAzul.getTinta();
            CantRojoActual = boliRoja.getTinta();

            Console.WriteLine("\nCantidad boli {0} despues de pintar:{1}", azul, CantAzulActual);
            Console.WriteLine("Cantidad boli {0} despues de pintar:{1}\n\n", rojo, CantRojoActual);


            boliAzul.recargar();
            boliRoja.recargar();



            CantAzulActual = boliAzul.getTinta();
            CantRojoActual = boliRoja.getTinta();

            Console.WriteLine("\nCantidad boli {0} despues de recargar:{1}", azul, CantAzulActual);
            Console.WriteLine("Cantidad boli {0} despues de recargar:{1}\n\n", rojo, CantRojoActual);





            Console.ReadKey();


        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej15
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero_A=0,
                numero_B=0;
            bool validarNumeros = false;
            string operador="+";
            string seguir = "s";

            do
            {

                Console.WriteLine("--------------Nuevo calculo--------------\n\n");

                while (!validarNumeros)
                {
                    Console.WriteLine("Ingrese el primer operando:");
                    validarNumeros = int.TryParse(Console.ReadLine(), out numero_A);
                }
                validarNumeros = false;

                while (!validarNumeros)
                {
                    Console.WriteLine("Ingrese el segundo operando:");
                    validarNumeros = int.TryParse(Console.ReadLine(), out numero_B);
                }

                Console.WriteLine("Que operacion desea realizar:");
                operador = Console.ReadLine();

                calculadora.mostrar(calculadora.calcular(numero_A,numero_B,operador));

                Console.WriteLine("Desea continuar realizando operaciones aritemticas?");
                seguir=Console.ReadLine();
                Console.WriteLine("\n\n");
                validarNumeros = false;

            } while (string.Compare(seguir, "s")==0);

            Console.WriteLine("\n\n\nGracias por operar con calculadoras pepe.\n\n");
            Console.ReadKey();

        }
    }
}

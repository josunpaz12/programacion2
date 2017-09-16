using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_Clase3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a=0,
                b=0,
                c=0,
                d=0,
                e=0,
                f=0;


            bool validarNumero = false;
            int resultado;

            while (!validarNumero)
            {
                Console.WriteLine("Ingrese el primer valor:");
                validarNumero = int.TryParse(Console.ReadLine(), out a);
            }
            validarNumero = false;

            while (!validarNumero)
            {
                Console.WriteLine("Ingrese el primer segundo:");
                validarNumero = int.TryParse(Console.ReadLine(), out b);
            }
            validarNumero = false;

            while (!validarNumero)
            {
                Console.WriteLine("Ingrese el tercer valor:");
                validarNumero = int.TryParse(Console.ReadLine(), out c);
            }
            
            //validarNumero = false;

            calculadora calculadora1 = new calculadora(a, b, c);
 

            resultado=calculadora1.sumar();

            Console.WriteLine("El resultado de la suma de la primera instancia es:{0}",resultado);

            validarNumero = false;
            while (!validarNumero)
            {
                Console.WriteLine("\n\nIngrese el primer valor:");
                validarNumero = int.TryParse(Console.ReadLine(), out d);
            }
            validarNumero = false;

            while (!validarNumero)
            {
                Console.WriteLine("Ingrese el primer segundo:");
                validarNumero = int.TryParse(Console.ReadLine(), out e);
            }
            validarNumero = false;

            while (!validarNumero)
            {
                Console.WriteLine("Ingrese el tercer valor:");
                validarNumero = int.TryParse(Console.ReadLine(), out f);
            }


            calculadora calculadora2 = new calculadora(d, e, f);

            resultado = calculadora2.sumar();

            Console.WriteLine("El resultado de la suma de la segunda instancia es:{0}", resultado);


            validarNumero = false;
            while (!validarNumero)
            {
                Console.WriteLine("\n\nIngrese el primer valor:");
                validarNumero = int.TryParse(Console.ReadLine(), out a);
            }
            validarNumero = false;

            while (!validarNumero)
            {
                Console.WriteLine("Ingrese el primer segundo:");
                validarNumero = int.TryParse(Console.ReadLine(), out b);
            }
            validarNumero = false;

            while (!validarNumero)
            {
                Console.WriteLine("Ingrese el tercer valor:");
                validarNumero = int.TryParse(Console.ReadLine(), out c);
            }

            calculadora1.valor1 = a;
            calculadora1.valor2 = b;
            calculadora1.valor3 = c;


            resultado = calculadora1.sumar();

            Console.WriteLine("El resultado de la suma de la primera nuevamente instancia es:{0}", resultado);

            Console.ReadKey();
            
        }
    }
}

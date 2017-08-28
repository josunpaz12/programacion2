using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Ej15
{
    class calculadora
    {
        public static int calcular(int a, int b, string c)
        {
            int resultado = 0;

            if (string.Compare(c, "/") == 0)
            {
                if (validar(b))
                {
                    resultado = a / b;
                }
                else
                {
                    Console.WriteLine("El segundo operando es 0, no es posible dividirlos.");
                }

            }
            else if (string.Compare(c, "+") == 0)
            {
                resultado = a + b;

            }
            else if (string.Compare(c, "-") == 0)
            {
                resultado = a - b;
            }
            else {
                resultado = a * b;
            }
                



            return resultado;
        }

            
        private static bool validar(int a)
        {
            bool retorno = true;

            if (a == 0)
                retorno = false;

            return retorno;
        
         }

        public static void mostrar(int a)
        {
            Console.WriteLine("El resultado es:{0}",a);
        }
    }
}

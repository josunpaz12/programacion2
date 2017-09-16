using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajoPractico_1
{
    class Calculadora
    {

        public static double operar(Numero numero1, Numero numero2, string operador)
        {
            double a = numero1.getNumero();
            double b = numero2.getNumero();
            double retorno = 0;

            switch (operador)
            {
                case "+":
                    retorno = a + b;
                    break;

                case "-":
                    retorno = a - b;
                    break;

                case "*":
                    retorno = a * b;
                    break;

                case "/":
                    if (b == 0)
                        retorno = 0;
                    else
                        retorno = a / b;
                    break;
            }

            return retorno;

        }

        public static string validarOperador(string operador)
        {
            string retorno = "+";

            if (operador == "-" || operador == "/" || operador == "*")
            {
                retorno = operador;
            }

            return retorno;
        }

    }
}

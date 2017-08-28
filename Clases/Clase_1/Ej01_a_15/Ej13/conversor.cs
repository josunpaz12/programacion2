using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej13
{
    class conversor
    {
        public static string DecimalBinario(double numero)
        {
            string retorno="";

            while (numero != 0)
            {
                if (numero % 2 == 1)
                {
                    retorno=string.Concat(retorno, "1");
                    numero = (numero-1) / 2;
                }
                else
                {
                    retorno=string.Concat(retorno, "0");
                    numero = numero / 2;

                }


            }

            retorno = Reverse(retorno);

            return retorno;
        }


        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

    }
}

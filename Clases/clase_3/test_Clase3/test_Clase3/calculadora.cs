using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test_Clase3
{
    public class calculadora
    {
        public int valor1;
        public int valor2;
        public int valor3;

        //constructor de la clase, tiene que tener mismo nombre.
        public  calculadora(int a, int b, int c)
        {
            valor1=a;
            valor2=b;
            valor3=c;
        }

        public int sumar()
        {
            int resultado;
            resultado = valor1 + valor2 + valor3;
            return resultado;        
        }

    }
}

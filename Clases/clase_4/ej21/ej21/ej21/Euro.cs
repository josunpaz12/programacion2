using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dinero
{
    class Euro
    {
        private double _euroCant;
        private double _euroValor;

        public Euro(double a, double b)
        {
            this._euroCant = a;
            this._euroValor = b;
        }

        public static double operator *(double a, double b)
        {
            double retorno=0;
            return retorno = a * 1.18974;
        }




    }
}

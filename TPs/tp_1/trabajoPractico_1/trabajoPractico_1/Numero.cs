using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajoPractico_1
{
    class Numero
    {
        private double _Numero;

        public double getNumero()
        {
            return this._Numero;
        }

        public Numero()
        {
            this._Numero = 0;
        }

        public Numero(string numero)
        {
            setNumero(numero);

        }


        public Numero(double a)
        {
            this._Numero = a;
        }

        private double validarNumero(string numeroString)
        {
            double aux;

            if (!double.TryParse(numeroString, out aux))
                aux = 0;

            return aux;
        }

        private void setNumero(string numero)
        {
            double aux;
            aux = validarNumero(numero);
            if (aux!=0)
            {
                this._Numero = aux;
            }


        }


    }
}

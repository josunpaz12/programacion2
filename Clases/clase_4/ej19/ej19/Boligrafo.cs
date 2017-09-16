using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace distinto
{
    class Boligrafo
    {
        private ConsoleColor _color;
        private int _tinta;

        public Boligrafo(ConsoleColor a, int b)
        {
            this._color = a;
            this._tinta = b;
        }

        public bool Pintar (int gasto)
        {
            bool retorno = false;
            if (gasto < this._tinta)
            {
                this._tinta=this._tinta-gasto;
                retorno = true;
            }

            return retorno;
        
        }

      public  void recargar()
        {
            if (this._tinta + 50 > 100)
            {
                this._tinta = 100;
            }
            else
            {
                this._tinta = this._tinta + 50;
            }

        }

        public int getTinta()
        {
            return this._tinta;
        }

        public ConsoleColor getColor()
        {
            return this._color;
        }

    }
}

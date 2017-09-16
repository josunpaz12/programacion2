using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class punto
    {
        private int _x;
        private int _y;

        public punto(int x, int y)
        {
            this._x = x;
            this._y = y;
        }
        

        public int getX()
        {
            return _x;
        }

        public int getY()
        {
            return _y;
        }


    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clase2
{
    class Validacion
    {

        static public bool Validar(int x, int y, int z)
        {
            if (z < x || z > y)
            {
                return false;
            }else       
            return true;
        }
        

    }
}

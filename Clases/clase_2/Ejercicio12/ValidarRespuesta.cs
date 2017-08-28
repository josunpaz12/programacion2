using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12
{
    class ValidarRespuesta
    {

        bool ValidaS_N()
        {
            while (Console.ReadLine() != "S" && Console.ReadLine() != "N")
            {
                Console.WriteLine("Valor ingresado incorrecto, desea continuar?S/N:");
            }

            if (Console.ReadLine() == "S")
            {
                return true;
            }else
            {
                return false;    
            }
        }
    }
}

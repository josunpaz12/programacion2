using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    class rectangulo
    {
        public float area;
        public float lado;
        public float perimetro;

        public punto vertice1;
        public punto vertice2;
        public punto vertice3;
        public punto vertice4;

        public rectangulo (punto vertice1, punto vertice3)        
        {
            int altura;
            this.vertice1 = vertice1;
            this.vertice2 = new punto(vertice1.getX(),vertice3.getY());
            this.vertice3 = vertice3;
            this.vertice4 = new punto(vertice3.getX(), vertice1.getY());

            this.lado =Math.Abs( vertice1.getX() - vertice3.getY());
            altura = Math.Abs(vertice2.getX() - vertice4.getY());


        }


    }
}

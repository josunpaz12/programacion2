using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_clase_5
{
    class Producto
    {
        private string _codigoDeBarra;
        private string _marca;
        private float _precio;

       public Producto(string marca, string codigo, float precio)
        {
            this._marca = marca;
            this._codigoDeBarra = codigo;
            this._precio = precio;
        }

       public string GetMarca()
       {
           return this._marca;
       }

       public float GetPrecio()
       {
           return this._precio;
       }


       public string MostrarProducto(Producto p)
       {
           string precio,
               codigo,
               marca;
           float precioFloat;

           precioFloat = p.GetPrecio();
           marca = p.GetMarca();
           codigo = p._codigoDeBarra;

           precio = Convert.ToString(precioFloat);

           return "Marca:"+marca+" Precio:"+ precio+" Codigo de Barras:" + codigo+".";

       }


        public static explicit operator string(Producto p)
        {
            return (string)p._codigoDeBarra;
        }

        public static bool operator ==(Producto p, string marca)
        {
            bool retorno = false;
            if(String.Compare(p.GetMarca(),marca)==0)
                retorno = true;

            return retorno;
        }

        public static bool operator ==(Producto a, Producto b)
        {
            bool retorno = false;

            if (String.Compare(a.GetMarca(), b.GetMarca()) == 0)
            {
                if (String.Compare(a._codigoDeBarra, b._codigoDeBarra) == 0)
                    retorno = true;
            }

            return retorno;
        }

        public static bool operator !=(Producto p, string marca)
        {
            bool retorno = true;
            if (String.Compare(p.GetMarca(), marca) == 0)
                retorno = false;

            return retorno;
        }

        public static bool operator !=(Producto a, Producto b)
        {
            bool retorno = true;

            if (String.Compare(a.GetMarca(), b.GetMarca()) == 0)
            {
                if (String.Compare(a._codigoDeBarra, b._codigoDeBarra) == 0)
                    retorno = false;
            }

            return retorno;
        }

    }
}

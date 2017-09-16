using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_clase_5
{
    class Estante
    {
        private Producto[] _productos;
        private int _ubicacionEstante;

        private Estante(int capacidad)
        { 
            this._productos=new Producto[capacidad];
        }

        public Estante(int capacidad, int ubicacion):this(capacidad)
        { 
            this._ubicacionEstante = ubicacion;
        }

        public Producto[] GetProductos()
        {
            return this._productos;
        }

        public string MostrarEstante(Estante e)
        {
            string estanteString;
            string retorno;

            estanteString = Convert.ToString(e._ubicacionEstante);
            retorno = Convert.ToString(e.GetProductos());

            return "Los productos " + retorno + " en estante " + estanteString + ".";
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator ==(Estante e, Producto p)
        { 
            bool retorno = false;
            int len,
                i;
            //crear flag
            len = e._productos.Length;
            //esto me devuelve el codigo de barras de P
            string pCodDeBarrasString = (string)p;
            string epCodDeBarrasString;

            for (i = 0; i < len; i++)
            {
                epCodDeBarrasString = (string)e._productos[i];
                if (String.Compare(pCodDeBarrasString,epCodDeBarrasString) == 0)
                {
                    retorno = true;
                }

            }

            for (i = 0; i < len; i++)
            {
                if (String.Compare(p.GetMarca(),e._productos[i].GetMarca()) == 0)
                {
                    retorno = true;
                }

            }
            return retorno;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator !=(Estante e, Producto p)
        {
            bool retorno = true;
            int len,
                i;
            len = e._productos.Length;

            for (i = 0; i < len; i++)
            {
                if (String.Compare(p.GetMarca(), e._productos[i].GetMarca()) == 0)
                {
                    retorno = false;
                }

            }
            return retorno;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static bool operator +(Estante e, Producto p)
        {
            bool retorno = false,
                flag = false;
            int len,
                i;
            len = e._productos.Length;

            for (i = 0; i < len; i++)
            {
                if (String.Compare(p.GetMarca(), e._productos[i].GetMarca()) == 0)
                {
                    //retorno = true;
                    flag = true;
                    break;
                }

            }

            if (flag)
            {
                for (i = 0; i < len; i++)
                {
                    if (e._productos[i].GetMarca() == null)
                    {
                        e._productos[i] = p;
                        retorno = true;
                        break;
                    }
                }

            }

            return retorno;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="e"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Estante operator -(Estante e, Producto p)
        {
            Estante estante = null;
            int len,
                i;
            len = e._productos.Length;

            for (i = 0; i < len; i++)
            {
                if (String.Compare(p.GetMarca(), e._productos[i].GetMarca()) == 0)
                {
                    estante = e;
                    e._productos[i] = null;
                    break;
                }

            }

            //utilizando el == de producto , un producto es igual 
            //si tiene misma marca y misco codigo de barras

            return estante;
        }


    }
}

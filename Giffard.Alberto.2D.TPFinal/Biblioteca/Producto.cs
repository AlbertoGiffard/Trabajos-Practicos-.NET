using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Biblioteca
{
    [XmlInclude(typeof(Droide))]
    [XmlInclude(typeof(Tunica))]
    [XmlInclude(typeof(Sable))]
    /// <summary>
    /// Clase Padre de la cual heredaran los productos Droide, Tunica, Sable
    /// </summary>
    public abstract class Producto
    {
        private int stock;
        private int precio;
        private bool modeloRebelde;
        public Producto()
        {

        }
        public Producto(int stock, int precio, bool modeloRebelde)
        {
            this.stock = stock;           
            this.precio = precio;
            this.modeloRebelde = modeloRebelde;
        }
        /// <summary>
        /// Si no hay stock lanzara una Exception del tipo SinStockException, en el caso contrario
        /// nos devolvera el número de Stock
        /// </summary>
        public bool HayStock
        {
            get
            {
                bool result = false;

                if (this.stock > 0)
                {
                    result = true;
                }
                else
                {
                    throw new SinStockException("No hay stock");
                }

                return result;
            }
        }
        public int Stock
        {
            get
            {
                return this.stock;
            }
            set
            {
                if (this.stock > 0)
                {
                    this.stock = value;
                }
            }
        }
        /// <summary>
        /// Nos devolverá el precio
        /// </summary>
        public int Precio
        {
            get
            {
                return this.precio;
            }
            set
            {
                this.precio = value;
            }
        }
        /// <summary>
        /// Si es modelo rebelde nos devolvera "Si" en el caso contrario, "No"
        /// </summary>
        public string ModeloRebelde
        {
            get
            {
                string result = String.Empty;

                if (this.modeloRebelde)
                {
                    result = "Si";
                }
                else
                {
                    result = "No";
                }

                return result;
            }
            set
            {
                if (this.modeloRebelde)
                {
                    this.modeloRebelde = true;
                }
                else
                {
                    this.modeloRebelde = false;
                }
            }
        }
        /// <summary>
        /// El metodo será sobrescrito por las clases derivadas
        /// </summary>
        /// <returns>La información al respecto de cada producto</returns>
        public abstract string MostrarInformación();
    }
}

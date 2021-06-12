using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class Cliente
    {
        private int id;
        private string nombre;
        private bool esRebelde;
        private List<Producto> listaProductos;

        public Cliente()
        {
        }
        public Cliente(int id, string nombre, bool esRebelde) : this()
        {
            this.id = id;
            this.nombre = nombre;
            this.esRebelde = esRebelde;
            this.listaProductos = new List<Producto>();
        }
        public Cliente(int id, string nombre, bool esRebelde, List<Producto> listaProductos) : this(id, nombre, esRebelde)
        {
            this.id = id;
            this.nombre = nombre;
            this.esRebelde = esRebelde;
            this.listaProductos = listaProductos;
        }
        /// <summary>
        /// Devuelve el valor del id
        /// </summary>
        public int Id
        {
            get
            {
                return this.id;
            }
            set
            {
                this.id = value;
            }
        }
        /// <summary>
        /// devuelve el valor del nombre
        /// </summary>
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        /// <summary>
        /// Si es rebelde nos devolvera "Si" en el caso contrario, "No"
        /// </summary>
        public string EsRebelde
        {
            get
            {
                string result = String.Empty;

                if (this.esRebelde)
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
                if (this.esRebelde)
                {
                    this.esRebelde = true;
                }
                else
                {
                    this.esRebelde = false;
                }
            }
        }
        /// <summary>
        /// Devuelve el listado del cliente
        /// </summary>
        public List<Producto> ListadoProductos
        {
            get
            {
                return this.listaProductos;
            }
            set
            {
                this.listaProductos = value;
            }
        }
        /// <summary>
        /// Listara todos los productos comprados por el cliente
        /// </summary>
        /// <returns>El listado completo de productos en el caso de que hayan</returns>
        public string ListarProductos()
        {
            int total = 0;
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"CLIENTE: {this.nombre}");
            // Se le agrego esta condicion para que no muestre una lista si no tiene productos
            if (this.listaProductos.Count > 0)
            {
                foreach (Producto producto in this.listaProductos)
                {
                    sb.AppendLine($"{producto.MostrarInformación()}");
                    total += producto.Precio;
                }
            }
            else
            {
                sb.AppendLine($"Aún sin productos comprados");
            }
            sb.AppendLine($"TOTAL: ${total}");

            return sb.ToString();
        }
        /// <summary>
        /// Sobrecargo el metodo para que me muestre la información del cliente
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"ID: {this.id}");
            sb.AppendLine($"Nombre: {this.nombre}");
            sb.AppendLine($"Rebelde: {this.EsRebelde}");
            sb.AppendLine($"-----------------------");

            return sb.ToString();
        }
        /// <summary>
        /// Si hay stock del producto, se podra agregar al listado de productos comprados al cliente
        /// </summary>
        /// <param name="cliente"></param>
        /// <param name="producto"></param>
        /// <returns>Devolvera true si se pudo sumar el producto y si no hay stock arrojara una excepcion del tipo
        /// SinStockException</returns>
        public static Cliente operator +(Cliente cliente, Producto producto)
        {
            if(cliente != null && producto != null)
            {
                try
                {
                    if (producto.HayStock)
                    {
                        cliente.listaProductos.Add(producto);
                        producto.Stock--;
                    }
                }
                catch (SinStockException e)
                {
                    throw new SinStockException("Nos quedamos sin stock", e);
                }                
            }

            return cliente;
        }
    }
}

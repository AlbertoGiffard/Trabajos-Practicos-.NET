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
        private List<Productos> listaProductos;
        /// <summary>
        /// Si no se le pasa una lista al constructor, se inicializa en el constructor de tres parametros
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="esRebelde"></param>
        public Cliente(int id, string nombre, bool esRebelde)
        {
            this.id = id;
            this.nombre = nombre;
            this.esRebelde = esRebelde;
            this.listaProductos = new List<Productos>();
        }
        public Cliente(int id, string nombre, bool esRebelde, List<Productos> listaProductos) : this(id, nombre, esRebelde)
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
        }
        /// <summary>
        /// Listara todos los productos comprados por el cliente
        /// </summary>
        /// <returns>El listado completo de productos en el caso de que hayan</returns>
        public string ListarProductos()
        {
            StringBuilder sb = new StringBuilder();
            // Se le agrego esta condicion para que no muestre una lista si no tiene productos
            if (this.listaProductos.Count > 0)
            {
                foreach (Productos producto in this.listaProductos)
                {
                    sb.AppendLine($"{producto.MostrarInformación()}");
                }
            }
            else
            {
                sb.AppendLine($"Aún sin productos comprados");
            }

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
        public static bool operator +(Cliente cliente, Productos producto)
        {
            bool result = false;
            
            if(cliente != null && producto != null)
            {
                try
                {
                    if (producto.HayStock)
                    {
                        cliente.listaProductos.Add(producto);
                        producto.Stock--;
                        result = true;
                    }
                }
                catch (SinStockException e)
                {
                    throw new SinStockException("Nos quedamos sin stock", e);
                }                
            }

            return result;
        }
    }
}

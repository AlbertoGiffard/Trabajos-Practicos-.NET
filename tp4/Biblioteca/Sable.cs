using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// Uno de los posibles productos que hereda de Productos
    /// </summary>
    public class Sable : Producto, IFabricar<Sable>
    {
        private Cristales cristal;
        private int cantidadDeHojas;
        /// <summary>
        /// Si no le pasa el parametro de cantidadDeHojas del sable de luz
        /// lo setea por default como una hoja
        /// </summary>
        /// <param name="cirstal"></param>
        /// <param name="stock"></param>
        /// <param name="precio"></param>
        /// <param name="modeloRebelde"></param>
        public Sable()
        {

        }
        public Sable(Cristales cristal, int stock, int precio, bool modeloRebelde) : base(stock, precio, modeloRebelde)
        {
            this.cristal = cristal;
            this.cantidadDeHojas = 1;
        }
        public Sable(Cristales cristal, int cantidadDeHojas, int stock, int precio, bool modeloRebelde) : this(cristal, stock, precio, modeloRebelde)
        {
            this.cristal = cristal;
            this.cantidadDeHojas = cantidadDeHojas;
        }
        public int CantidadDeHojas
        {
            get
            {
                return this.cantidadDeHojas;
            }
            set
            {
                this.cantidadDeHojas = value;
            }
        }
        public Cristales Cristal
        {
            get
            {
                return this.cristal;
            }
            set
            {
                this.cristal = value;
            }
        }
        /// <summary>
        /// La cantidad debe ser mayor a 0 y menor a 5 para lograr ensamblar
        /// </summary>
        /// <param name="objeto"></param>
        /// <returns>Devolvera true si cumple las condiciones</returns>
        public bool Ensamblar(Sable objeto)
        {
            bool result = false;

            if (objeto.CantidadDeHojas > 0 && objeto.CantidadDeHojas < 5)
            {
                result = true;
            }

            return result;
        }
        /// <summary>
        /// Si el objeto es null no indicara que se entrego
        /// </summary>
        /// <param name="objeto"></param>
        /// <returns>Devolverá el texto de entregado o arrojara una exception dependiendo 
        /// de si el objeto es nulo</returns>
        public string Entregar(Sable objeto)
        {
            string result = String.Empty;

            if (!(objeto is null))
            {
                result = "Status: Entregado";
            }
            else
            {
                throw new Exception("No se logró entregar");
            }

            return result;
        }

        /// <summary>
        /// Muestra la informacion del sable de luz
        /// </summary>
        /// <returns>La informacion</returns>
        public override string MostrarInformación()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Producto: Sable de Luz");
            sb.AppendLine($"Cristal usado: {this.cristal.ToString()}");
            sb.AppendLine($"N° de hojas: {this.cantidadDeHojas}");
            sb.AppendLine($"Modelo Rebelde: {this.ModeloRebelde}");
            sb.AppendLine($"Precio: {this.Precio}");
            sb.AppendLine($"---------------------------");

            return sb.ToString();
        }
        /// <summary>
        /// Posibles valores de los cristales
        /// </summary>
        public enum Cristales
        {
            Azul,
            Rojo,
            Morado,
            Verde
        }
    }
}

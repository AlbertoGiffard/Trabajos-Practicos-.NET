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
    public class Sable : Productos, IFabricar
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

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
    public class Tunica : Productos, IFabricar
    {
        private Tamanio tamanio;
        private Color color;
        public Tunica(Tamanio tamanio, Color color, int stock, int precio, bool modeloRebelde) : base(stock, precio, modeloRebelde)
        {
            this.tamanio = tamanio;
            this.color = color;
        }
        /// <summary>
        /// Muestra la informacion de la tunica
        /// </summary>
        /// <returns>La informacion</returns>
        public override string MostrarInformación()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Producto: Túnica");
            sb.AppendLine($"Tamaño: {this.tamanio.ToString()}");
            sb.AppendLine($"Color: {this.color.ToString()}");
            sb.AppendLine($"Modelo Rebelde: {this.ModeloRebelde}");
            sb.AppendLine($"Precio: {this.Precio}");
            sb.AppendLine($"---------------------------");

            return sb.ToString();
        }
        /// <summary>
        /// Posibles valores de tamanio
        /// </summary>
        public enum Tamanio
        {
            Corta,
            Larga
        }
        /// <summary>
        /// Los posibles valores de color
        /// </summary>
        public enum Color
        {
            Clara,
            Oscura
        }
    }
}

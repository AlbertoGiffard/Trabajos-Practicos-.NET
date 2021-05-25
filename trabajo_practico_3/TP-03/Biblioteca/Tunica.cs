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
    public class Tunica : Productos, IFabricar<Tunica>
    {
        private Corte tamanio;
        private Color color;
        public Tunica(Corte tamanio, Color color, int stock, int precio, bool modeloRebelde) : base(stock, precio, modeloRebelde)
        {
            this.tamanio = tamanio;
            this.color = color;
        }
        public Corte Tamanio
        {
            get
            {
                return this.tamanio;
            }
        }
        /// <summary>
        /// Si el tamaño no es del corte personalizada se podrá ensamblar
        /// ya que no se comercializa mas personalizada
        /// </summary>
        /// <param name="objeto"></param>
        /// <returns></returns>
        public bool Ensamblar(Tunica objeto)
        {
            bool result = false;

            if(!(objeto.Tamanio is Tunica.Corte.Personalizada))
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
        public string Entregar(Tunica objeto)
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
        public enum Corte
        {
            Corta,
            Larga,
            Personalizada
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

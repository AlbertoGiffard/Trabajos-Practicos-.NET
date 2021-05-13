using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// No podrá tener clases heredadas.
    /// </summary>
    public sealed class Taller
    {
        private int espacioDisponible;
        private List<Vehiculo> vehiculos;

        #region "Constructores"
        /// <summary>
        /// Se encarga de inicializar la lista
        /// </summary>
        private Taller()
        {
            this.vehiculos = new List<Vehiculo>();
        }
        public Taller(int espacioDisponible) : this()
        {
            this.espacioDisponible = espacioDisponible;
        }
        #endregion

        #region "Sobrecargas"
        /// <summary>
        /// Muestro el estacionamiento y TODOS los vehículos
        /// </summary>
        /// <returns></returns>
        public string ToString()
        {
            return Taller.Listar(this, ETipo.Todos);
        }
        #endregion

        #region "Métodos"
        /// <summary>
        /// Expone los datos del elemento y su lista (incluidas sus herencias)
        /// SOLO del tipo requerido
        /// </summary>
        /// <param name="t">Elemento a exponer</param>
        /// <param name="ETipo">Tipos de ítems de la lista a mostrar</param>
        /// <returns></returns>
        public static string Listar(Taller t, ETipo tipo)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Tenemos {0} lugares ocupados de un total de {1} disponibles\n", t.vehiculos.Count, t.espacioDisponible);
            foreach (Vehiculo v in t.vehiculos)
            {
                switch (tipo)
                {
                    case ETipo.Ciclomotor:
                        if (v is Ciclomotor)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    case ETipo.Sedan:
                        if (v is Sedan)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    case ETipo.SUV:
                        if (v is Suv)
                        {
                            sb.AppendLine(v.Mostrar());
                        }
                        break;
                    default:
                        sb.AppendLine(v.Mostrar());
                        break;
                }
            }

            return sb.ToString();
        }
        #endregion

        #region "Operadores"
        /// <summary>
        /// Agregará un elemento a la lista en tal caso  que no exista en ella
        /// </summary>
        /// <param name="t">Objeto donde se agregará el elemento</param>
        /// <param name="vehiculo">Objeto a agregar</param>
        /// <returns></returns>
        public static Taller operator +(Taller t, Vehiculo vehiculo)
        {
            bool noEstaRepetido = true;

            if (!(t is null) && !(vehiculo is null))
            {
                if (t.vehiculos.Count() < t.espacioDisponible)
                {
                    foreach (Vehiculo v in t.vehiculos)
                    {
                        if (v == vehiculo)
                        {
                            noEstaRepetido = false;
                            break;
                        }
                    }
                    if (noEstaRepetido)
                    {
                        t.vehiculos.Add(vehiculo);
                    }
                }

            }

            return t;
        }
        /// <summary>
        /// Quitará un elemento de la lista
        /// </summary>
        /// <param name="taller">Objeto donde se quitará el elemento</param>
        /// <param name="vehiculo">Objeto a quitar</param>
        /// <returns></returns>
        public static Taller operator -(Taller t, Vehiculo vehiculo)
        {
            bool existe = false;
            if (!(t is null) && !(vehiculo is null))
            {
                foreach (Vehiculo v in t.vehiculos)
                {
                    if (v == vehiculo)
                    {
                        existe = true;
                        break;
                    }
                }
                if (existe)
                {
                    t.vehiculos.Remove(vehiculo);
                }
            }

            return t;
        }
        #endregion

        #region "Enumerados"
        public enum ETipo
        {
            Ciclomotor,
            Sedan,
            SUV,
            Todos
        }
        #endregion
    }
}

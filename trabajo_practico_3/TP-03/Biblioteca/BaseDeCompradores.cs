using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    /// <summary>
    /// En esta clase se encontrara el listado de los compradores de la fabrica
    /// </summary>
    public sealed class BaseDeCompradores
    {
        private List<Cliente> listaClientes;
        private string nombreDeLaBase;
        /// <summary>
        /// El constructor publico se encarga de llamar al constructor privado para inicializar la lista
        /// </summary>
        private BaseDeCompradores()
        {
            listaClientes = new List<Cliente>();
        }
        public BaseDeCompradores(string nombreDeLaBase) : this()
        {
            this.nombreDeLaBase = nombreDeLaBase;
        }
        /// <summary>
        /// Listado de clientes
        /// </summary>
        /// <returns>Me muestra el listado de los clientes que hay</returns>
        public string MostrarClientes()
        {
            StringBuilder sb = new StringBuilder();
            if (this.listaClientes.Count > 0)
            {
                foreach (Cliente cliente in this.listaClientes)
                {
                    sb.AppendLine($"{cliente.ToString()}");
                }
            }
            else
            {
                sb.AppendLine($"No hay ninguno, necesitamos compradores...");
            }

            return sb.ToString();
        }
        public static BaseDeCompradores operator +(BaseDeCompradores baseCompradores, Cliente cliente)
        {
            if (!(baseCompradores is null) && !(cliente is null))
            {
                if (baseCompradores != cliente)
                {
                    baseCompradores.listaClientes.Add(cliente);
                }
                else
                {
                    throw new ClienteExisteException($"El cliente con el ID {cliente.Id} ya existe");
                }
            }

            return baseCompradores;
        }
        public static bool operator ==(BaseDeCompradores baseCompradores, Cliente cliente)
        {
            bool result = false;

            foreach (Cliente c in baseCompradores.listaClientes)
            {
                if (c.Id == cliente.Id)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }

        public static bool operator !=(BaseDeCompradores baseCompradores, Cliente cliente)
        {
            return !(baseCompradores == cliente);
        }
    }
}

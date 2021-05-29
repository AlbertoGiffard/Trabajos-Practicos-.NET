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
        /// <summary>
        /// Busca el ID mas alto del listado, si da InvalidOperationException implica que la lista aun no tiene compradores
        /// por lo tanto retornará uno
        /// </summary>
        /// <param name="baseCompradores"></param>
        /// <returns> Retorna el ID mas alto de la lista de clientes</returns>
        public static int IdMasAlto(BaseDeCompradores baseCompradores)
        {
            int result = -1;
            if (baseCompradores is null)
            {
                throw new Exception("Error Interno, la lista no puede sumar clientes.\nComuníquese con el programador");
            }
            else
            {
                try
                {
                    result = baseCompradores.listaClientes.Max(c => c.Id);
                }
                catch (InvalidOperationException)
                {
                    return result = 1;
                }
            }

            return result;
        }
        public static Cliente TraerCliente(BaseDeCompradores baseCompradores, int id)
        {
            Cliente cliente = null;

            foreach (Cliente c in baseCompradores.listaClientes)
            {
                if (c.Id == id)
                {
                    cliente = c;
                    break;
                }
            }

            return cliente;
        }
        /// <summary>
        /// Realizará del cliente a la base
        /// </summary>
        /// <param name="baseCompradores"></param>
        /// <param name="cliente"></param>
        /// <returns>La base con el nuevo cliente si lo logró sumar</returns>
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
        /// <summary>
        /// A partir del ID del cliente verifica si el cliente pertenece a la base
        /// </summary>
        /// <param name="baseCompradores"></param>
        /// <param name="cliente"></param>
        /// <returns>true si lo logro conseguir, false si no</returns>
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
        /// <summary>
        /// a partir de un valor de tipo int busca si el valor con el id pertenece a la base
        /// </summary>
        /// <param name="baseCompradores"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        //public static bool operator ==(BaseDeCompradores baseCompradores, int id)
        //{
        //    bool result = false;

        //    foreach (Cliente c in baseCompradores.listaClientes)
        //    {
        //        if (c.Id == id)
        //        {
        //            result = true;
        //            break;
        //        }
        //    }

        //    return result;
        //}
        //public static bool operator !=(BaseDeCompradores baseCompradores, int id)
        //{
        //    return !(baseCompradores == id);
        //}

    }
}

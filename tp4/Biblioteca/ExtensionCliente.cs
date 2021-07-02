using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class ExtensionCliente
    {
        /// <summary>
        /// Buscara si la instancia de Cliente es un Sith
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>se le agregara "es sith" en caso que EsRebelde venga false</returns>
        public static string BuscarSith(this Cliente cliente)
        {
            string resultado = string.Empty;

            if (cliente.EsRebeldeBoolean)
            {
                resultado = "Si";
            }
            else
            {
                resultado = "No (Es Sith)";
            }

            return resultado;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class ClienteExisteException : Exception
    {
        public ClienteExisteException(string mensaje) : base(mensaje) { }
        public ClienteExisteException(string mensaje, Exception innerException) : base(mensaje, innerException) { }
    }
}

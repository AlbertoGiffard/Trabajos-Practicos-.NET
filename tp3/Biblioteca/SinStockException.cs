using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public class SinStockException : Exception
    {
        public SinStockException(string mensaje) : base(mensaje) { }
        public SinStockException(string mensaje, Exception innerException) : base(mensaje, innerException) { }
    }
}

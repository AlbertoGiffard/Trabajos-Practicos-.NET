using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public interface IFabricar<T>
    {
        bool Ensamblar(T objeto);
        string Entregar(T objeto);
    }
}

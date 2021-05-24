using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public interface IFabricar
    {
        bool Ensamblar<T, U>(T atributo1, U atributo2);
        string Entregar();
    }
}

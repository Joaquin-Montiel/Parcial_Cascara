using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Clases
{
    public interface IGuardar<T>
    {
        void Guardar(T item, string ruta);
    }
}

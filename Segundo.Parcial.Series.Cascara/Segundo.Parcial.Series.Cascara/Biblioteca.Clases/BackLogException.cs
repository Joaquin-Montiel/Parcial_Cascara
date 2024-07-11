using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Clases
{
    public class BackLogException : Exception
    {
        public BackLogException(string mensaje) : base(mensaje)
        { 
        }

        public BackLogException(string mensaje, Exception innerException) : base (mensaje, innerException)
        {

        }
    }

}

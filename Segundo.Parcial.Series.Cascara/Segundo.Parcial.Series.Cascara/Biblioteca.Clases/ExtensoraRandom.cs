using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Clases
{
    public static class ExtensoraRandom
    {
        private static Random random = new Random();

        public static int GetRandomIndex(this ManejadorBacklog manejador, int maxSize)
        {
            return random.Next(0, maxSize);
        }
    }
}

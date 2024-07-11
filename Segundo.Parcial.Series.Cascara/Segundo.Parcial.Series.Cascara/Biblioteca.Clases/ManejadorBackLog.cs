using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca.Clases
{
    public class ManejadorBacklog
    {
        public delegate void SerieParaVerHandler(Serie serie);
        public event SerieParaVerHandler NuevaSerieParaVer;

        public void IniciarManejador(List<Serie> series)
        {
            Task.Run(() => MoverSeries(series));
        }

        private void MoverSeries(List<Serie> series)
        {
            for (int i = 0; i < series.Count; i++) 
            {
                int index = this.GetRandomIndex(series.Count());

                AccesoDatos.ActualizarSerie(series[index]);

                Thread.Sleep(1500);

                NuevaSerieParaVer?.Invoke(series[index]);
   
            }
        }
    }
}

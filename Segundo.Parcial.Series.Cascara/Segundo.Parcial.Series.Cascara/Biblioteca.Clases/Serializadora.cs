

using System.Text.Json;
using System.Xml.Serialization;

namespace Biblioteca.Clases
{
    public class Serializadora : IGuardar<List<Serie>>
    {
         public void Guardar(List<Serie> items, string ruta)
         {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Serie>));
                using (FileStream stream = new FileStream(ruta, FileMode.Create))
                {
                    serializer.Serialize(stream, items);
                }
            }
            catch (Exception ex)
            {
                throw new BackLogException("Error al guardar en formato XML.", ex);
            }
         }

        void IGuardar<List<Serie>>.Guardar(List<Serie> items, string ruta)
        {
            try
            {
                string jsonString = JsonSerializer.Serialize(items);
                File.WriteAllText(ruta, jsonString);
            }
            catch (Exception ex)
            {
                throw new BackLogException("Error al guardar en formato JSON.", ex);
            }
        }

    }
}


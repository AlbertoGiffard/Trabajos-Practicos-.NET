using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Biblioteca
{
    public static class PuntoXml<T> where T : new()
    {
        public static bool Guardar(T data, string ruta)
        {
            bool result = false;

            try
            {
                using (XmlTextWriter xmlTextWriter = new XmlTextWriter(ruta, Encoding.UTF8))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(T));
                    serializer.Serialize(xmlTextWriter, data);
                    result = true;
                }
            }
            catch (UnauthorizedAccessException e)
            {
                throw new UnauthorizedAccessException("Sin los permisos necesarios", e);
            }
            catch (ArgumentNullException e)
            {
                throw new ArgumentNullException("La ruta de acceso es Null ", e);
            }
            catch (ArgumentException e)
            {
                throw new ArgumentException("Es una cadena de longitud cero, contiene sólo espacios en blanco, o contiene caracteres no válidos", e);
            }
            catch (Exception e)
            {
                throw new Exception("Hubo un error al intentar escribir en la ruta", e);
            }

            return result;
        }

        public static T Leer(string ruta)
        {
            //bool result = false;
            T result = new T();

            try
            {
                if (File.Exists(ruta))
                {
                    using (XmlTextReader xmlTextReader = new XmlTextReader(ruta))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(T));
                        result = (T)serializer.Deserialize(xmlTextReader);
                        //result = true;
                    }
                }
                else
                {
                    throw new Exception("No se encuentra el archivo");
                }
            }
            catch (FileNotFoundException e)
            {
                throw new FileNotFoundException("No se encontro el archivo", e);
            }
            catch (DirectoryNotFoundException e)
            {
                throw new DirectoryNotFoundException("No se encontro el directorio", e);
            }
            catch (ArgumentNullException e)
            {
                throw new ArgumentNullException("La ruta de acceso es Null ", e);
            }
            catch (ArgumentException e)
            {
                throw new ArgumentException("Es una cadena de longitud cero, contiene sólo espacios en blanco, o contiene caracteres no válidos", e);
            }
            catch (Exception e)
            {
                throw new Exception("Hubo un error al intentar leer la ruta", e);
            }

            return result;
        }
    }
}

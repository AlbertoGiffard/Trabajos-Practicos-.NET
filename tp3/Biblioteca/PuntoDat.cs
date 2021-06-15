using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class PuntoDat
    {
        public static bool Guardar(string texto, string ruta)
        {
            bool result = false;
            Stream stream = null;
            BinaryWriter formatter = null;

            try
            {
                using (stream = new FileStream(ruta, FileMode.Create))
                {
                    formatter = new BinaryWriter(stream);
                    formatter.Write(texto);
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

        public static string Leer(string ruta)
        {
            string result = String.Empty;
            try
            {
                using (BinaryReader reader = new BinaryReader(File.OpenRead(ruta)))
                {
                    result = reader.ReadString();
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

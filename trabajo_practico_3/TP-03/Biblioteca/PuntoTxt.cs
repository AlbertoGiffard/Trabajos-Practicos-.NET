using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class PuntoTxt
    {
        public static void Guardar(string texto, string nombreDeArchivo)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(nombreDeArchivo))
                {
                    writer.WriteLine(texto);
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
        }

        public static string Leer(string ruta)
        {
            StreamReader reader = null;
            string result = String.Empty;

            try
            {
                if (File.Exists(ruta))
                {
                    using (reader = new StreamReader(ruta))
                    {
                        result = reader.ReadToEnd();
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
                throw new Exception("Hubo un error al intentar escribir en la ruta", e);
            }
            finally
            {
                if (reader != null)
                {
                    reader.Close();
                }
            }

            return result;
        }
    }
}

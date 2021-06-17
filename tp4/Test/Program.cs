using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Biblioteca;
namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Bases
            BaseDeCompradores base1 = new BaseDeCompradores("Base de prueba");
            BaseDeCompradores base2 = new BaseDeCompradores("Base Vacia");
            //Clientes
            Cliente c1 = new Cliente(1, "Anakin", false);
            Cliente c2 = new Cliente(2, "Leia", true);
            Cliente c3 = new Cliente(3, "Palpatine", false);
            Cliente c4 = new Cliente(3, "Kylo", false);
            //Productos
            Producto p1 = new Droide(Droide.TipoDroide.Astromecanico, 2, 600, 1999, true);
            //el d1 al no tener un tipo definido, se le agrega por default de tipo de trabajo
            Droide d1 = new Droide(5, 344, 9999, false);
            Sable s1 = new Sable(Sable.Cristales.Azul, 7, 799, false);
            Sable s2 = new Sable(Sable.Cristales.Rojo, 9, 1, 900, false);
            //Sin stock t1
            Tunica t1 = new Tunica(Tunica.Corte.Larga, Tunica.Color.Oscura, 0, 199, true);
            Tunica t2 = new Tunica(Tunica.Corte.Personalizada, Tunica.Color.Oscura, 1, 199, true);
            //Sumar clientes a la base
            //Nos debe indicar que el cliente con el ID 3 ya esta repetido
            //por lo tanto no muestra a "Kylo"
            try
            {
                base1 += c1;
                base1 += c2;
                base1 += c3;
                base1 += c4;
            }
            catch (ClienteExisteException e)
            {
                Console.WriteLine(e.Message);
            }
            //mostrar a los clientes
            Console.WriteLine("Base 1:\n{0}", base1.MostrarClientes());
            Console.WriteLine("Base 2 (vacia):\n{0}", base2.MostrarClientes());

            //Sumar productos a los clientes
            //t1 no lo va a poder sumar porque no hay stock, el resto mostrará la info            
            try
            {
                c1 += p1;
                c1 += d1;
                c2 += t2;
                c2 += t1;
            }
            catch (SinStockException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //Console.WriteLine(c1.ToString());
            //Console.WriteLine(c1.ListarProductos());
            //Console.WriteLine(c2.ToString());
            //Console.WriteLine(c2.ListarProductos());

            //Mostrar si logro ensamblar el droide
            //Debe dar false ya que supera el numero de hojas del sable permitido
            Console.WriteLine(s2.Ensamblar(s2));

            //Guardar en el escritorio un txt con el listado de los productos y luego 
            //muestra el contenido del txt por consola
            try
            {
                //Guardar
                PuntoTxt.Guardar(c1.ListarProductos(), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\AlbertoGiffardTesting.txt");
                //Lee
                Console.WriteLine(PuntoTxt.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\AlbertoGiffardTesting.txt"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //Guardar en el escritorio un .dat con el listado de los productos y luego 
            //muestra el contenido del binario por consola
            try
            {
                //Guardar
                PuntoDat.Guardar(c1.ListarProductos(), Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\AlbertoGiffardTesting.dat");
                //Lee
                Console.WriteLine(PuntoDat.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\AlbertoGiffardTesting.dat"));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            //Guardar en el escritorio un .xml con el listado de los productos y luego 
            //muestra el contenido del XML por consola
            try
            {
                List<Producto> lista = c1.ListadoProductos;
                //Guardar
                PuntoXml<List<Producto>>.Guardar(lista, Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\AlbertoGiffardTesting.xml");

                //Lee                
                c2.ListadoProductos = PuntoXml<List<Producto>>.Leer(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\AlbertoGiffardTesting.xml");
                Console.WriteLine(c2.ListarProductos());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }
}

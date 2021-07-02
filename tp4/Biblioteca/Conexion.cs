using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biblioteca
{
    public static class Conexion
    {
        private static string conexionStr;
        /// <summary>
        /// Siempre inicializo con la misma base cada vez que se ejecuta el disparador
        /// </summary>
        static Conexion()
        {
            //Registro la data de la base de datos
            //cambiar nombre !!!!!!!!
            conexionStr = @"Data Source = .; Initial Catalog = TableTP4; Integrated Security = True";
        }
        /// <summary>
        /// La consulta se le pasa por parametro y el resto estaria parametrizado
        /// </summary>
        /// <param name="query"></param>
        /// <returns> true si no hubo problema </returns>
        private static bool EjecutarComando(string query)
        {
            bool result = false;

            using (SqlConnection conexion = new SqlConnection(conexionStr))
            {
                SqlCommand comando = new SqlCommand(query, conexion);

                conexion.Open();

                comando.ExecuteNonQuery();//INSERT - UPDATE - DELETE

                result = true;
            }

            return result;
        }
        /// <summary>
        /// Guarda el nuevo cliente en la base de datos
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>devuelve true si lo logro realizar</returns>
        public static bool GuardarCliente(Cliente cliente)
        {
            return Conexion.EjecutarComando($"INSERT INTO Cliente (Id, Nombre, EsRebelde) VALUES ('{cliente.Id}','{cliente.Nombre}','{cliente.EsRebeldeBoolean}')");
        }
        /// <summary>
        /// Elimina un cliente de la base de datos
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns>devuelve true si lo logro realizar</returns>
        public static bool EliminarCliente(Cliente cliente)
        {
            return Conexion.EjecutarComando($"DELETE FROM Cliente WHERE Id = {cliente.Id}");
        }
        /// <summary>
        /// Elimina los productos que correspondan al cliente
        /// </summary>
        /// <param name="cliente"></param>
        /// <returns></returns>
        public static bool EliminarProductos(Cliente cliente)
        {
            return Conexion.EjecutarComando($"DELETE FROM Producto WHERE Producto.ClienteId = {cliente.Id}");
        }
        /// <summary>
        /// Guarda el nuevo producto a partir del id del cliente
        /// </summary>
        /// <param name="producto"></param>
        /// <param name="clienteId"></param>
        /// <returns>devuelve true si lo logro realizar</returns>
        public static bool GuardarNuevoProducto(object producto, int clienteId)
        {
            string query = String.Empty;

            if (producto is Droide)
            {
                query = $"INSERT INTO Producto (ClienteId, TipoProducto, Stock, Precio, ModeloRebelde, TipoDroide, ModeloDroide, CorteTunica, ColorTunica, CristalSable, CantidadHojas) VALUES ('{clienteId}', 'Droide', '{((Droide)producto).Stock}', '{((Droide)producto).Precio}', '{((Droide)producto).ModeloRebeldeBoolean}', '{((Droide)producto).Tipo}', '{((Droide)producto).Modelo}', '{null}', '{null}', '{null}', '{null}')";

            }
            else if (producto is Tunica)
            {
                query = $"INSERT INTO Producto (ClienteId, TipoProducto, Stock, Precio, ModeloRebelde, TipoDroide, ModeloDroide, CorteTunica, ColorTunica, CristalSable, CantidadHojas) VALUES ('{clienteId}', 'Tunica', '{((Tunica)producto).Stock}', '{((Tunica)producto).Precio}', '{((Tunica)producto).ModeloRebeldeBoolean}', '{null}', '{null}', '{((Tunica)producto).Tamanio}', '{((Tunica)producto).CualColor}', '{null}', '{null}')";
            }
            else
            {
                query = $"INSERT INTO Producto (ClienteId, TipoProducto, Stock, Precio, ModeloRebelde, TipoDroide, ModeloDroide, CorteTunica, ColorTunica, CristalSable, CantidadHojas) VALUES ('{clienteId}', 'Sable','{((Sable)producto).Stock}', '{((Sable)producto).Precio}', '{((Sable)producto).ModeloRebeldeBoolean}','{null}', '{null}', '{null}', '{null}', '{((Sable)producto).Cristal}', '{((Sable)producto).CantidadDeHojas}')";
            }

            return Conexion.EjecutarComando(query);
        }
        /// <summary>
        /// busca todos los clientes de la base
        /// </summary>
        /// <returns>Retorna el listado de clientes </returns>
        public static List<Cliente> RetornarInformacionClientes()
        {
            List<Cliente> listado = new List<Cliente>();
            string query = "SELECT * FROM Cliente";

            using (SqlConnection conexion = new SqlConnection(conexionStr))
            {
                SqlCommand comando = new SqlCommand(query, conexion);

                conexion.Open();

                SqlDataReader dataReader = comando.ExecuteReader();//CONSULTA

                while (dataReader.Read())
                {
                    listado.Add(new Cliente(Convert.ToInt32(dataReader["Id"]), dataReader["Nombre"].ToString(), Convert.ToBoolean(dataReader["EsRebelde"])));
                }

                dataReader.Close();
            }

            return listado;
        }
        /// <summary>
        /// a partir del id busca al cliente en la base junto a sus productos
        /// </summary>
        /// <param name="id"></param>
        /// <returns> devuelve el cliente con toda su informacion </returns>
        public static Cliente RetornarInformacionCliente(int id)
        {
            Cliente persona = null;
            List<Producto> listadoProducto = Conexion.RetornarProductos(id);

            string query = $"SELECT * FROM Cliente WHERE Cliente.Id = '{id}'";

            using (SqlConnection conexion = new SqlConnection(conexionStr))
            {
                SqlCommand comando = new SqlCommand(query, conexion);

                conexion.Open();

                SqlDataReader dataReader = comando.ExecuteReader();

                while (dataReader.Read())
                {
                    persona = new Cliente(Convert.ToInt32(dataReader["ID"]), dataReader["Nombre"].ToString(), Convert.ToBoolean(dataReader["EsRebelde"]), listadoProducto);
                }

                dataReader.Close();
            }

            return persona;
        }
        /// <summary>
        /// Busca los productos que le pertenecen al cliente pasado por parametro
        /// </summary>
        /// <param name="id"></param>
        /// <returns>devuelve el listado de productos</returns>
        private static List<Producto> RetornarProductos(int id)
        {
            List<Producto> listado = new List<Producto>();
            string query = $"SELECT * FROM Producto WHERE Producto.ClienteId = '{id}'";
            //variables auxiliares para ser mas entendible el codigo
            int stock;
            int precio;
            bool modeloRebelde = false;
            //droide
            Droide.TipoDroide tipoDroide;
            int modelo;
            //tunica
            Tunica.Corte corte;
            Tunica.Color colorTunica;
            //sable
            Sable.Cristales cristal;
            int cantidadHojas;

            using (SqlConnection conexion = new SqlConnection(conexionStr))
            {
                SqlCommand comando = new SqlCommand(query, conexion);

                conexion.Open();

                SqlDataReader dataReader = comando.ExecuteReader();//CONSULTA

                while (dataReader.Read())
                {
                    stock = Convert.ToInt32(dataReader["Stock"]);
                    precio = Convert.ToInt32(dataReader["Precio"]);
                    modeloRebelde = Convert.ToBoolean(dataReader["ModeloRebelde"]);

                    switch (dataReader["TipoProducto"].ToString())
                    {
                        case "Droide":
                            switch (dataReader["TipoDroide"].ToString())
                            {
                                case "Astromecanico":
                                    tipoDroide = Droide.TipoDroide.Astromecanico;
                                    break;

                                case "Combate":
                                    tipoDroide = Droide.TipoDroide.Combate;
                                    break;

                                case "Medico":
                                    tipoDroide = Droide.TipoDroide.Medico;
                                    break;

                                default:
                                    tipoDroide = Droide.TipoDroide.Trabajo;
                                    break;
                            }
                            modelo = Convert.ToInt32(dataReader["ModeloDroide"]);
                            listado.Add(new Droide(tipoDroide, modelo, stock, precio, modeloRebelde));
                            break;

                        case "Tunica":
                            //corte
                            switch (dataReader["CorteTunica"].ToString())
                            {
                                case "Corta":
                                    corte = Tunica.Corte.Corta;
                                    break;

                                case "Larga":
                                    corte = Tunica.Corte.Larga;
                                    break;

                                default:
                                    corte = Tunica.Corte.Personalizada;
                                    break;
                            }
                            //color
                            switch (dataReader["ColorTunica"].ToString())
                            {
                                case "Clara":
                                    colorTunica = Tunica.Color.Clara;
                                    break;

                                default:
                                    colorTunica = Tunica.Color.Oscura;
                                    break;
                            }
                            listado.Add(new Tunica(corte, colorTunica, stock, precio, modeloRebelde));
                            break;

                        case "Sable":
                            //cristal
                            switch (dataReader["CristalSable"].ToString())
                            {
                                case "Azul":
                                    cristal = Sable.Cristales.Azul;
                                    break;

                                case "Morado":
                                    cristal = Sable.Cristales.Morado;
                                    break;

                                case "Rojo":
                                    cristal = Sable.Cristales.Rojo;
                                    break;

                                default:
                                    cristal = Sable.Cristales.Verde;
                                    break;
                            }
                            cantidadHojas = Convert.ToInt32(dataReader["CantidadHojas"]);
                            listado.Add(new Sable(cristal, cantidadHojas, stock, precio, modeloRebelde));
                            break;
                    }
                }

                dataReader.Close();
            }

            return listado;
        }
    }
}

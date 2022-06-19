using System;
using System.Collections.Generic;
using Entidades.Exceptions;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades.Base_de_datos
{
    public class ClienteDao
    {

        static private string cadenaConexion;
        static private SqlCommand comando;
        static private SqlConnection conexion;


        static ClienteDao()
        {
            cadenaConexion = "Data Source=.;Initial Catalog= BACOS; Integrated Security = True";
            comando = new SqlCommand();
            conexion = new SqlConnection(cadenaConexion);
            comando.CommandType = System.Data.CommandType.Text;
            comando.Connection = conexion;

        }

        /// <summary>
        /// Trae la data de la base de datos y lo agrega en una lista de clientes
        /// </summary>
        /// <returns>retorna una lista de clientes con la informacion de la base de datos</returns>
        public static List<Cliente> Leer()
        {

            List<Cliente> lista = new List<Cliente>();

            try
            {
                conexion.Open();
                comando.CommandText = "SELECT * FROM CLIENTES;";
                SqlDataReader dataReader = comando.ExecuteReader();
                while (dataReader.Read())
                {
                    lista.Add(new Cliente(DateTime.Parse(dataReader["FECHA_NACIMIENTO"].ToString()), dataReader["NOMBRE"].ToString().Trim(), Convert.ToInt32(dataReader["DNI"]), dataReader["DIRECCION"].ToString().Trim(), float.Parse((dataReader["DEUDA"].ToString()))));
                }

                dataReader.Close();
            }
            catch (Exception)
            {

            }
            finally
            {
                conexion.Close();
            }

            return lista;
        }


        /// <summary>
        /// guarda un cliente en la base de datos
        /// </summary>
        /// <param name="cliente">cliente a guardar</param>
        /// <returns></returns>
        public static int Guardar(Cliente cliente)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"INSERT INTO CLIENTES(DNI,NOMBRE,DIRECCION,DEUDA,FECHA_NACIMIENTO)  VALUES (@DNI,@NOMBRE,@DIRECCION,@DEUDA,@FECHA);";

                comando.Parameters.AddWithValue("@DNI", cliente.Dni);
                comando.Parameters.AddWithValue("@NOMBRE", cliente.NombreCompleto);
                comando.Parameters.AddWithValue("@DIRECCION", cliente.Direccion);
                comando.Parameters.AddWithValue("@DEUDA", cliente.Deuda);
                comando.Parameters.AddWithValue("@FECHA", cliente.FechaDeNacimiento);

                return comando.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw new BaseDeDatosException("Algo fallo guardando los clientes a la base de datos");
            }
            finally
            {
                conexion.Close();
            }
        }


        /// <summary>
        /// Borra el cliente pasado por parametro en la base de datos
        /// </summary>
        /// <param name="cliente">cliente a borrar</param>
        public static void Borrar(Cliente cliente)
        {

            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"DELETE FROM CLIENTES WHERE DNI = @DNI";
                comando.Parameters.AddWithValue("@DNI", cliente.Dni);


                comando.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw new BaseDeDatosException("Algo fallo guardando los clientes a la base de datos");
            }
            finally
            {
                conexion.Close();
            }


        }
        /// <summary>
        /// Modifica el cliente que se pase por parametro
        /// </summary>
        /// <param name="dni">dni del cliente a modificar</param>
        /// <param name="cliente">cliente con el que se le va a modificar</param>
        public static void Modificar(int dni, Cliente cliente)
        {
            try
            {
                comando.Parameters.Clear();
                conexion.Open();
                comando.CommandText = $"UPDATE CLIENTES SET DNI = @DNI, NOMBRE = @NOMBRE, FECHA_NACIMIENTO = @FECHA ,DIRECCION = @DIRECCION, DEUDA = @DEUDA WHERE CLIENTES.DNI = @DNIABUSCAR;";
                comando.Parameters.AddWithValue("@DNI", cliente.Dni);
                comando.Parameters.AddWithValue("@NOMBRE", cliente.NombreCompleto);
                comando.Parameters.AddWithValue("@DIRECCION", cliente.Direccion);
                comando.Parameters.AddWithValue("@DEUDA", cliente.Deuda);
                comando.Parameters.AddWithValue("@FECHA", cliente.FechaDeNacimiento);
                comando.Parameters.AddWithValue("@DNIABUSCAR", dni);

                comando.ExecuteNonQuery();

            }
            catch (Exception)
            {
                throw new BaseDeDatosException("Algo fallo guardando los clientes a la base de datos");
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}

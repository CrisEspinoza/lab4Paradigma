using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService2
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public bool actualizarPuntaje(int puntaje, string usu)
        {
            string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\krist\\OneDrive\\Documents\\soccerShips.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conexion = new SqlConnection(conn);
            string cone = "update Usuario SET Score = (@puntaje) WHERE Nombre = '"+usu+"'";
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conexion;
            cmd.CommandText = cone;
            cmd.Parameters.Add("@puntaje", SqlDbType.Int);
            cmd.Parameters["@puntaje"].Value = puntaje;
            conexion.Open();
            int resultado = cmd.ExecuteNonQuery();
            conexion.Close();
            return true;
        }

        public string apodoUs(string nombre)
        {

            string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\krist\\OneDrive\\Documents\\soccerShips.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conexion = new SqlConnection(conn);
            try
            {
                string apodo;
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Usuario WHERE Nombre=@nombre;", conexion);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                SqlDataReader cons = cmd.ExecuteReader();
                while (cons.Read())
                {
                    apodo = cons.GetString(3);
                    return apodo;
                }
                return "";
            }
            catch
            {
                return "";
            }
            finally
            {
                conexion.Close();
            }
        }

        public string equipoUs(string nombre)
        {
            string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\krist\\OneDrive\\Documents\\soccerShips.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conexion = new SqlConnection(conn);
            try
            {
                string equipo;
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Usuario WHERE Nombre=@nombre;", conexion);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                SqlDataReader cons = cmd.ExecuteReader();
                while (cons.Read())
                {
                    equipo = cons.GetString(4);
                    return equipo;
                }
                return "";
            }
            catch
            {
                return "";
            }
            finally
            {
                conexion.Close();
            }
        }

        public int puntajeUs(string nombre)
        {
            string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\krist\\OneDrive\\Documents\\soccerShips.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conexion = new SqlConnection(conn);
            try
            {
                int puntaje;
                conexion.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM Usuario WHERE Nombre=@nombre;", conexion);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                SqlDataReader cons = cmd.ExecuteReader();
                while (cons.Read())
                {
                   puntaje = cons.GetInt32(5);
                   return puntaje;
                }
                return 0;
            }
            catch
            {
                return 0;
            }
            finally
            {
                conexion.Close();
            }
        }

        public bool registrarUsuario(string nombre, string contrasena, string apodo, string equipoPreferido)
        {
            string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\krist\\OneDrive\\Documents\\soccerShips.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conexion = new SqlConnection(conn);

            conexion.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO Usuario (Nombre,Contrasena,Apodo,EquipoPreferido) VALUES (@name,@contra,@apodo,@equipo) ", conexion);
            
            cmd.Parameters.AddWithValue("@name", nombre);
            cmd.Parameters.AddWithValue("@contra", contrasena);
            cmd.Parameters.AddWithValue("@apodo", apodo);
            cmd.Parameters.AddWithValue("@equipo", equipoPreferido);
            return(cmd.ExecuteNonQuery()==1);
        }

        public bool usuario(string nombre, string contrasena) //Verificar si existe el usuario
        {
            string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\krist\\OneDrive\\Documents\\soccerShips.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conexion = new SqlConnection(conn);
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("select * from Usuario where Nombre=@name and Contrasena=@contra;", conexion);
                cmd.Parameters.AddWithValue("@name", nombre);
                cmd.Parameters.AddWithValue("@contra", contrasena);
                SqlDataReader cons = cmd.ExecuteReader();
                bool respuesta = cons != null && cons.HasRows;
                return respuesta;
            }
            catch
            {
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService1
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class Service1 : IService1
    {
        public bool registrarUsuario(string nombre, string contrasena, string apodo, string equipoPreferido)
        {
            string conn = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\krist\\OneDrive\\Documents\\soccerShips.mdf;Integrated Security=True;Connect Timeout=30";
            SqlConnection conexion = new SqlConnection(conn);
            try
            {
                conexion.Open();
                SqlCommand cmd = new SqlCommand("insert into Usuario(Nombre,Contrasena,Apodo,EquipoPreferido,Score) values (@name,contra,apodo,equipo,puntaje) ", conexion);
            }
            catch
            {

            }
            return false;

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

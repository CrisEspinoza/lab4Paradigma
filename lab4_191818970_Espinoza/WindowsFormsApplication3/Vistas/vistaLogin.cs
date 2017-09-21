using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication3.ServiceReference1;

namespace WindowsFormsApplication3.Vistas
{
    public partial class vistaLogin : Form
    {
        //Constructor de la vista.
        public vistaLogin()
        {
            InitializeComponent();
        }

        // Metodo que se activa al momento de presionar el boton aceptar de la vistaLogin.
        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            //Atributos que seran ocupados para almacenar la informacion.
            string nombre, contraseña, apodo, equipo;
            // Informcion que es rescatada de la vista login, son los datos que coloca el usuario.
            nombre = textBoxNombre.Text;
            apodo = textBoxApodo.Text;
            contraseña = textBoxContraseña.Text;
            equipo = comboBoxEquipo.Text;
            
            //Es cuando se instancia el servicio, con le fin de poder utilizar los metodos que se encuentran en el.
            Service1Client servicio = new Service1Client();

            /* Esta funcion nos sirve para registrar a un jugador dentro de la base de datos, tener en cuenta que esta 
            operacion se realiza por medio del servicio web, ya que el metodo que permite ingresar un nuevo usuario
            a la aplicacion esta implemtnado en el servicio web*/
            if (nombre != "" && apodo != "" && contraseña != "" && equipo != "")
            {
                if (servicio.registrarUsuario(nombre, contraseña, apodo, equipo))
                {
                    VistaMenu vistaMenu = new VistaMenu(nombre);
                    vistaMenu.Show();
                    this.Dispose(true);
                }
                else
                {
                    MessageBox.Show("No se pudo realizar el registro del usuario.");
                }
            }
            else
            {
                MessageBox.Show("Todo los campos son obligatorios");
            }
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void vistaLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

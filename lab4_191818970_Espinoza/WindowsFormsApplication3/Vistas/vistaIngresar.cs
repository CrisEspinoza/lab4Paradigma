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
using WindowsFormsApplication3.Vistas;

namespace WindowsFormsApplication3
{
    public partial class VistaIngresar : Form 
    {
        // Atributos que son ocupados dentro de la clase.
        string nombre;
        string contrasena;

        //constructor de la vista .
        public VistaIngresar()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Atributos que seran los encargados de almacenar la informacion que sera rescata de la vista.
            nombre = textNombre.Text;
            contrasena = textContraseña.Text;

            // Se instancia al servicio para pder asi usar sus metodos que contiene .
            Service1Client servicio = new Service1Client();

            /* Verifica que los datos coincidan con los que se encuentran dentro de la base de datos, tener en cuenta
            que esto se realiza atras del servicio, ya que es un metodo que esta implementado en el servicio, que se 
            encarga de dar el permiso a usuario de proseguir a la batalla siempre y cuando este registrado dentro de la 
            aplicacion*/
            if (servicio.usuario(nombre, contrasena))
            {
                VistaMenu vistaMenu = new VistaMenu(nombre);
                vistaMenu.Show();
                this.Dispose(true);
            }
            else
            {
                MessageBox.Show("Usuario incorrecto");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAtras_Click(object sender, EventArgs e)
        {
            this.Dispose(false);
        }
    }
}

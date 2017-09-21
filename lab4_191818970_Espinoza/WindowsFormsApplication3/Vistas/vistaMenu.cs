using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication3.modelos;
using WindowsFormsApplication3.ServiceReference1;

namespace WindowsFormsApplication3.Vistas
{
    public partial class VistaMenu : Form
    {
        // Atributos que contiene la clase
        string nombre;
        string equipo;
        int puntaje;
        string apodo;

        //Constructor de la clase
        public VistaMenu(string nombre)
        {
            InitializeComponent();
            this.nombre = nombre;
        }

        public VistaMenu ()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*Sentencia que permite conectarse con el servicio web que se implemento, con el fin de poder obtener la 
            informacino que se encuentra en la base de datos que se creo, paa luego asi poder llamar a la vista perfil
            que se encarga de mostrar dicha informacion ontenida al usuario.*/
            Service1Client servicio = new Service1Client();

            /*Metodos que son llamados al servidos que se encargar de obtener datos del usuarion que se almacenan en la tabla
            usuario.*/
            puntaje = servicio.puntajeUs(nombre);
            equipo = servicio.equipoUs(nombre);
            apodo = servicio.apodoUs(nombre);

            // Llamamos a la vista terreno con los datos que se rescataron.
            vistaPerfil vistaPerfil = new vistaPerfil(nombre,puntaje,equipo,apodo);
            vistaPerfil.Show();
        }

        private void butCargarPartida_Click(object sender, EventArgs e)
        {
        }

        private void butJugar_Click(object sender, EventArgs e)
        {
            // Se encarga de llamar a la vista que recibe los parametros para comenzar la batalla.
            vistaPrevBatalla vistaPreviaBatalla = new vistaPrevBatalla(nombre);
            vistaPreviaBatalla.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class VistaPrincipal : Form
    {
        public VistaPrincipal()
        {
            InitializeComponent();
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Operacion que se encarga de llamar a la vista ingresar , para que el usuario pueda ingresar sus datos.
            VistaIngresar frm = new VistaIngresar();
            frm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void buttonPartidaRapida_Click(object sender, EventArgs e)
        {
            /* Operacion que se encarga de llegar al usuario a la ventana de juego rapido, que pueda jugar dentro 
             de la aplicacoin sin necesidad que tenga que ingresar con un usuario.*/
            Vistas.vistaPrevBatalla vistaPrevBatalla = new Vistas.vistaPrevBatalla();
            vistaPrevBatalla.Show();
        }

        private void buttonSalir_Click(object sender, EventArgs e)
        {
            // Opcion que cierra la aplicacion por completo.
            Application.Exit();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            //Desprende la vista de login para que el usuario pueda crear un neuvo usuario dentro de la aplicacion.
            Vistas.vistaLogin vistaLogin = new Vistas.vistaLogin();
            vistaLogin.Show();
        }

        private void VistaPrincipal_Load(object sender, EventArgs e)
        {

        }
    }
}

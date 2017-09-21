using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3.Vistas
{
    public partial class vistaPerfil : Form
    {
        public vistaPerfil(string nombre, int puntaje, string equipo,string apodo)
        {
            /* Operacion que se encarga de mostrar la informacion obtenida en la vista, para que ele usuaior pueda
            apreciarla*/
            InitializeComponent();
            labelEquipo.Text = equipo;
            labelNombre.Text = nombre;
            labelPuntaje.Text = puntaje.ToString();
            labelApodo.Text = apodo;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void vistaPerfil_Load(object sender, EventArgs e)
        {

        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            // Oopcoin que cirrea la vista actual.
            this.Dispose(false);
        }
    }
}

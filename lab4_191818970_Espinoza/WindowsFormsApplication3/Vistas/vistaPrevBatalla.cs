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

namespace WindowsFormsApplication3.Vistas
{
    public partial class vistaPrevBatalla : Form
    {
        // atributos que son ocupados dentro de la aplicaciom.
        int fila, columna, cantBarcos;
        string nivel, equipoPreferido,nombre;

        //Constuctor de la clase.
        public vistaPrevBatalla (string nombre)
        {
            InitializeComponent();
            this.nombre = nombre;
        }

        public vistaPrevBatalla()
        {
            InitializeComponent();
        }

        private void vistaPrevBatalla_Load(object sender, EventArgs e)
        {
        }

        private void buttonVolver_Click(object sender, EventArgs e)
        {
            //Comando que se encarga de ocultar la vista y poder vovler a la vista anterior.
            this.Dispose();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            /*Funcion que esta encargada de recibir la totalidad de los datos que va a ingresar el usuario para poder
             comenzar la partida.
             Ademas de verificar cada uno de ellos, ver que todo los cambos esten completados ya que esta vista
             no permite que deje espacios en blanco, todo los datos son importante para el desarrollo de la partida.
             Luego de verificar cada uno de los datos, se encarga de llamar a la vista Terreno entregandole
             todo los parametros ingresados con los que se haran desarollo el resto del juego.*/
            if (numericFila.Value != 0 && numericColumna.Value != 0 && numericCantBarcos.Value != 0 && comboEquipoPreferido.SelectedItem != null && comboNivel.SelectedItem != null)
            {
                if ((int)numericFila.Value % 2 == 0)
                {
                    fila = (int)numericFila.Value + 1;
                    columna = (int)numericColumna.Value;
                    cantBarcos = (int)numericCantBarcos.Value;
                    nivel = comboNivel.SelectedItem.ToString();
                    equipoPreferido = comboEquipoPreferido.SelectedItem.ToString();
                    /*Se ooperara segun sea el nivel que haya escogido e usuario, ya que en esta opcion es donde 
                    se controla el tiempo de la aplcaicon y la dificultad (cantidad de barcos ) que va a tener
                    el enemigo al momento de crear el tablero.*/

                    if (nivel == "Facil")
                    {
                        Pnj computador = new Pnj(cantBarcos, nivel, equipoPreferido);
                        Jugador usuario = new Jugador(cantBarcos, equipoPreferido, nombre);
                        VistaTerreno vistaTerreno = new VistaTerreno(computador, usuario, 300, cantBarcos, nivel, equipoPreferido, fila, columna);
                        vistaTerreno.Show();
                        this.Dispose();
                    }
                    else if (nivel == "Medio")
                    {
                        Pnj computador = new Pnj((cantBarcos + 1), nivel, equipoPreferido);
                        Jugador usuario = new Jugador(cantBarcos, equipoPreferido, nombre);
                        VistaTerreno vistaTerreno = new VistaTerreno(computador, usuario, 600, cantBarcos, nivel, equipoPreferido, fila, columna);
                        vistaTerreno.Show();
                        this.Dispose();
                    }
                    else if (nivel == "Dificil")
                    {
                        Pnj computador = new Pnj((cantBarcos + 2), nivel, equipoPreferido);
                        Jugador usuario = new Jugador(cantBarcos, equipoPreferido, nombre);
                        VistaTerreno vistaTerreno = new VistaTerreno(computador, usuario, 900, cantBarcos, nivel, equipoPreferido, fila, columna);
                        vistaTerreno.Show();
                        this.Dispose();
                    }
                    MessageBox.Show("Puede colocar +/- " + cantBarcos.ToString() + "barcos en su campo de batalla");
                }
                else
                {
                    MessageBox.Show("Debe ingresar un numero par en las columnas");
                    numericFila.ResetText();
                }
            }
            else
            {
                MessageBox.Show("Rellene todo los datos solicitados");
            }      
        }
    }
}

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
using System.Threading;

namespace WindowsFormsApplication3.Vistas
{
    public partial class VistaTerreno : Form
    {
        Terreno terreno; // agregacion 
        Terreno terrenoGuardado; // agregacion 
        Jugador jugador; // agregacion  
        Barco barco = new Barco(); // Composicion
        Pnj comp; // agregacion  
        int  cantBarcos;
        public Casilla casillaaux; // agregacion 

        /* Constructor que genera los objetos segun los datos que nos ingresa el usuario en la vista. 
         Recibe como parametro: 
         computador: que es la variable que contiene al usuario enemigo
         jugador: Variable que contiene al jugador 
         tiempoo : Variable que se encarga de dar tiempo a la partida
         canBarcos: cantidad de barcos que contendra el terreno 
         nivel: Nivel de dificultad que tendra la partida
         equipoPreferido: Equipo que representa al jugador, ademas de ser el barco jefe.
         file y columna: cantidad de filas y columna que contendra la matriz.
         */
        public VistaTerreno(Pnj computador, Jugador jugador, int tiempoo, int cantBarcos, string nivel, String equipoPreferido,int fila , int columna)
        {
            InitializeComponent();
            this.comp = computador;
            this.jugador = jugador;
            this.cantBarcos = cantBarcos;
            this.terreno = new Terreno(jugador,fila, columna, cantBarcos, cantBarcos, nivel, equipoPreferido,computador,tiempoo,this);
            this.terreno = terreno.createBoard(terreno,this);
            jugador.Board = terreno;
            terreno.posicionarBarcos(computador, this.terreno);
            terreno.verImagen(terreno, computador);
            buttonBarcoMAtaque.Enabled = false;
            buttonBarcoEAtaque.Enabled = false;          
        } 

        public VistaTerreno (Terreno terreno)
        {
            this.terrenoGuardado = terreno;
        }
        /* Esta funcion nos permite actualizar el comboBox despues de ya haber colocado el barco jefe.
        Se encarga de ir actualizando el combobox cada ves que se va colocando un barco, el cambio mas brusto
        que se produce es cuando ya se colca el barco jefe y aparecen los otros barcos para que peudan completar
        la accion de colocar los barcos dentro del campo de juego.*/
        public void actualizarCombox()
        {
            if (jugador.BarcosActuales == 1 && terreno.bandera == false)
            {
                comboBoxBarcos.Items.RemoveAt(0);
                for (int i = 1; i < terreno.listaGeneral.Count; i++)
                {
                    comboBoxBarcos.Items.Add(terreno.listaGeneral[i]);
                }
            }
        }

        private void VistaTerreno_Load(object sender, EventArgs e)
        {
            comboBoxBarcos.Items.Add(terreno.listaGeneral[0]);
        }                   

        private void panelTablero_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonColocarAceptar_Click(object sender, EventArgs e)
        {
            int indice;
            /* bandera que nos ayuda ir controlando la cantidad de barcos que el usuario va colocando.
             Se encarga de ir controlando la cantidad de barcos que se van colocando dentro del campo de juego,
             ademas de ayudar a cumplir con la condicion que el usuairo puede tener +/- 1 barco que el enemigo.*/
            if (terreno.bandera)
            {
                if ((cantBarcos + 1) >= jugador.BarcosActuales)
                {
                    indice = (comboBoxBarcos.SelectedIndex);
                    if (jugador.BarcosActuales == 0)
                    {
                        barco = terreno.listaGeneral[indice];
                    }

                    else
                    {
                        barco = terreno.listaGeneral[indice + 1];
                    }
                }
                else
                {
                    MessageBox.Show("Maxima cantidad de barcos ya colocada!!, Puede comenzar la batalla");
                }
            }
            else
            {
                MessageBox.Show("Seleccione primero el barco a colocar en el terreno!!");
            }
        }       

        /*Boton que le permite al usuario rendirse de la partida, ademas de para el tiempo y dejar como 
         nulo el terreno.
         Accion que le da a copcion al usuario d epoder retirar o rendirse de la partida en el momento que estime 
         conveniente, ademas de dejar como null el tablero para poder crear otro al momento que desea nuevamente
         iniciar una nueva partida, sin dejar de lado que tambien se encarga de detener el tiempo de la partida.*/
        private void buttonRendirse_Click(object sender, EventArgs e)
        {
            tiempo.Stop();
            MessageBox.Show("A perdido la partida, el ganador es la Consola");
            terreno = null;
            jugador.Terreno = null;
            comp.Terreno = null;
            Thread.Sleep(1000);
            this.Dispose(false);
            VistaMenu vm = new VistaMenu();
        }

        private void buttonDisparar_Click(object sender, EventArgs e)
        {
            /*Permite ir controlando la cantidad de barcos que va colocando el usuario, permite ir verificando si la 
             cantidad de barcos aun no super por +/- 1 la cantidad de barcos que tiene la maquina.
             Ademas de obligar al usario a colocar al menos un barco en el terreno oponente.
             Solo dejara comenzar la partida si la diferencias de barcos con el oponenete es de +/- 1 barco.*/
            if (jugador.BarcosActuales != 0)
            {
                if (jugador.BarcosActuales == cantBarcos || jugador.BarcosActuales == (cantBarcos - 1) || jugador.BarcosActuales == (cantBarcos + 1))
                {
                    label2.Text = terreno.time.ToString();
                    tiempo.Enabled = true;
                    MessageBox.Show("Puede comenzar la batalla, suerte!!!");
                    buttonComenzarBatalla.Enabled = false;
                    buttonColocarAceptar.Enabled = false;
                    comboBoxBarcos.Enabled = false;
                    buttonBarcoEAtaque.Enabled = true;
                    buttonBarcoMAtaque.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Coloco la cantidad de barcos ingresada");
                }
            }
            else
            {
                MessageBox.Show("Coloque al menos un barco en su terreno!");
            }
        }

        private void comboBoxBarcos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxBarcos.SelectedItem.ToString() == null)
            {

            }
            else
            {
                terreno.bandera = true;
            }
        }        

        /*Funcion que permite ir verificando si despues de realizarse un ataque existe un ganador.
         Se encarga de ir verificando y comprobando que cada ves que termina la accion completa del ataque, es decir,
         tanto el ataque del usuairo como del oponenete comprobar si hay ganador dentro de la partida*/
        public void comprobarGanador(Pnj comp,Jugador jugador)
        {
            if (comp.CantidadBarcos == 0)
            {
                MessageBox.Show("El ganador del juego es " + jugador.Apodo + ", Felicitaciones!!!");
                buttonBarcoEAtaque.Enabled = false;
                buttonBarcoMAtaque.Enabled = false;
                tiempo.Stop();
                Thread.Sleep(3000);
                this.Dispose(false);
            }
            else if (jugador.BarcosActuales == 0)
            {
                MessageBox.Show("El ganador del juego es la computador, Intentalo nuevamente!!! ");
                buttonBarcoEAtaque.Enabled = false;
                buttonBarcoMAtaque.Enabled = false;
                tiempo.Stop();
                Thread.Sleep(3000);
                this.Dispose(false);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void buttonBarcoMAtaque_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Escoge barco con el cual va a realizar el disparo");
            terreno.bandera1 = true;
        }

        private void buttonBarcoEAtaque_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Escoger barco enemigo a realizar ataque");
            terreno.bandera2 = true;
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            jugador.Board = terreno;
            MessageBox.Show("Terreno guardado con exito");
            this.Dispose();
        }

        /*Reloj que contrala el tiempo de la partida.
         Se encarga de ir actualizando el tiempo al pasar cad segundo, si el tiempo llega a 0, quiere decir que la 
         partida llego a su fin.*/
        private void tiempo_Tick(object sender, EventArgs e)
        {
            terreno.time--;
            label2.Text = terreno.time.ToString() ;
            if (terreno.time == 0)
            {
                tiempo.Enabled = false;
                MessageBox.Show("Tiempo finalizado, ha ganado la computadora!! ");
                terreno = null;
                buttonBarcoEAtaque.Enabled = false;
                buttonBarcoMAtaque.Enabled = false;
                Thread.Sleep(2000);
                Dispose(false);
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            label2.Text = terreno.time.ToString();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }      

        /*Funcion importante, es la que proporciona eventos a la casilla:
         1. Permite que cada ves que el usuario quiera ver la informacion de unso de sus barcos, se mostrara
         en el cuadro que se encuentra en la vista batalla, esta operacion se va controlando mediante una bandera
         puesta, que opera al momento que sea un barco que este en terreno del usuario se cambie el estado de la 
         bandera para poder mostrar la informcion del barco dentro de la vista terreno.
         2. Controla con una bandera de por miedo el putShip, para que el usuario vaya colocand uno a uno sus
         barcos dentro de la matriz de juego. Ademas de ir comprobando la operacion de que el usuario debe tener 
         siempre una cantidad de barcos que no supere +/- 1 barco del enemigo, en el caso que esa opcion no se cumpla
         la bandera impuesta no se cambiara de estado y quiere decir que no dejar entrar a la accion.
         3. Controla que la casilla para reazilar el ataque sea del oponente y no ataque dentro de su misma matriz.
         Es una funcion bastante importante dentro de la aplicacion, ya que es la que controla cada una de las acciones
         que puede realizar en usuario dentro de la aplicacion.
         Como se menciono anteriormente, esta operacion se controla mediante una bandera boolena, que cambia de estado
         si la casilla que escoje pertenece a la matriz enemiga, con el fin de poder controlar que el ataque sea ejecutado
         en una de las casillas del enemigo y no en su propio terreno.*/
        public void acciones(object sender, EventArgs e)
        {
            int fila, columna;
            bool estado;
            Casilla accion = (Casilla)sender;
            if (accion.fila > terreno.InfoTablero[0]/2 && accion.Barco != null)
            {
                labelNombreBarco.Text = accion.Barco.Nombre.ToString();
                labelNivelBarco.Text = accion.Barco.Nivel.ToString();
                labelMunicionBarco.Text = accion.Barco.Municion.ToString();
                labelVidaBarco.Text = accion.Barco.Vida.ToString();
                labelArmaBarco.Text = accion.Barco.Arma;
            }
            else
            {
                labelNombreBarco.Text = "-";
                labelNivelBarco.Text = "-";
                labelMunicionBarco.Text = "-";
                labelVidaBarco.Text = "-";
                labelArmaBarco.Text = "-";
            }
            if (terreno.bandera)
            {
                fila = accion.Fila;
                columna = accion.Columna;
                estado = accion.Estado;
                if (jugador.BarcosActuales < (cantBarcos+1))
                {
                    terreno.putShip(fila, columna, estado, terreno, barco);
                    actualizarCombox();
                }
                else
                {
                    MessageBox.Show("Ya coloco la cantidad maxima de barcos, puede comenzar su batalla, Suerte !!!");
                    terreno.bandera = false;
                }                                                              
            }   
            else if (terreno.bandera1)
            {
                if (accion.fila >= (terreno.InfoTablero[0]/2) && accion.estado == true)
                {
                    casillaaux = accion;
                    terreno.bandera1 = false;
                    MessageBox.Show("Barco escogido par el ataque");
                }
                else
                {
                    MessageBox.Show("Escoja un barco de su terreno");
                    terreno.bandera1 = true;
                }
            }
            else if (terreno.bandera2)
            {
                if (accion.fila < (terreno.InfoTablero[0] / 2))
                {
                    terreno.ataque(casillaaux, accion, terreno);
                }
                else
                {
                    MessageBox.Show("Escoja una casilla enemiga");
                    terreno.bandera2 = true;
                }
            }
        }

        
    }
}

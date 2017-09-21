using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3.modelos
{
    public class Jugador : Usuario // tener en cuenta que hereda de usuario
    {
        // Atributos que se ocuparan dentro de la clase.
        int cantBarcos, puntaje;
        Barco[] barcos; // agregacion 
        Barco jefe = new Barco(); // composocion
        int barcosActuales;
        string jefeBarco;
        Terreno board; // agregacion

        //Contrsuctor de la clase:

        /* Se encarga de generar un arreglo de barcos con la cantidad de barcos que se ingreso, ademas de otorgar
         el barco jefe de inmediato, ya que el barco jefe siempre sera su equipo preferido.*/
        public Jugador(int cantBarcos, string equipoPreferido, string nombre)
        {
            this.Nombre = nombre;
            this.cantBarcos = cantBarcos;
            barcos = new Barco[(cantBarcos + 1)];
            this.barcosActuales = 0;
            jefe = jefe.jefeBarco(0, equipoPreferido);
            barcos[0] = jefe;
        }

        // gey y set de la clase.
        public int Puntaje
        {
            get
            {
                return this.puntaje;
            }
            set
            {
                this.puntaje = value;
            }
        }

        public string JefeBarco
        {
            get
            {
                return this.jefeBarco;
            }
            set
            {
                this.jefeBarco = value;
            }
        }

        public int CantBarcos
        {
            get
            {
                return this.cantBarcos;
            }
            set
            {
                this.cantBarcos = value;
            }
        }

        public int BarcosActuales
        {
            get
            {
                return this.barcosActuales;
            }
            set
            {
                this.barcosActuales = value;
            }
        }

        public Barco[] Barcos
        {
            get
            {
                return this.barcos;
            }
            set
            {
                this.barcos = value;
            }
        }

        public Terreno Board
        {
            get
            {
                return this.board;
            }
            set
            {
                this.board = value;
            }
        }

        public override string ToString()
        {
            return Nombre;
        }

    }
}

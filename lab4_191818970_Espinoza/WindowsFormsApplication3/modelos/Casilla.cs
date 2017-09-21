using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApplication3.modelos
{
    public class Casilla : System.Windows.Forms.Button
    {
        // Atributos que seran ocupados dentro de la clase.
        public int fila, columna;
        public bool estado;
        Barco barco; // agregacion
        bool atacado;

        /*Consutrctor de la clase.
         Se puede observar que son asignado cada uno de los datos a la variable de la casilla, para asi despues
         tener un mejor manejo de datos dentro del juego.*/

        public Casilla (int fila, int columna, bool estado, Barco barco)
        {
            this.fila = fila;
            this.columna = columna;
            this.estado = estado;
            this.barco = barco;
            this.Size = new Size(35,35);
            this.atacado = false;
        }

        // gey y set de la clase
        public int Fila
        {
            get
            {
                return this.fila;
            }
            set
            {
                this.fila = value;
            }
        }

        public int Columna
        {
            get
            {
                return this.columna;
            }
            set
            {
                this.columna = value;
            }
        }

        public Barco Barco
        {
            get
            {
                return this.barco;
            }
            set
            {
                this.barco = value;
            }
        }

        public bool Estado
        {
            get
            {
                return this.estado;
            }
            set
            {
                this.estado = value;
            }
        }

        public bool Atacado
        {
            get
            {
                return this.atacado;
            }
            set
            {
                this.atacado = value;
            }
        }
    }
}

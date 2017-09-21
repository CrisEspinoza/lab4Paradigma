using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3.modelos
{
    public class Pnj : Usuario // tener en cuenta que hereda de usuario
    {
        // Atributos que seran ocupados dentro de la clase.
        int cantBarcos, puntaje;
        public Barco[] barcos; // agregacion 
        public int largoBarcosTotal = 3;

        //contructor de la clase, ademas se encarga de guardar los barcos con los cuales jugara.
        public Pnj(int cantBarcos, string nivel, string equipoPreferido)
        {
            this.cantBarcos = cantBarcos;
            barcos = new Barco[cantBarcos];

            Barco jefe = new Barco(); // composicion 
            jefe = jefe.jefeBarcoN(equipoPreferido);
            barcos[0] = jefe;

            for (int i = 1; i < cantBarcos; i++)
            {
                Random r = new Random(DateTime.Now.Millisecond);
                Barco barco; // agregacion 
                Barco barcoN; // agregacion 
                int nivelBarco = r.Next(0, 2);
                int numeroBarco = r.Next(0, 3);

                if (nivelBarco == 0)
                {
                    barco = new Barco(); // composicion
                    barco = barco.barcoDebil(numeroBarco);
                    largoBarcosTotal = largoBarcosTotal + 1;
                    barcos[i] = barco;
                }

                if (nivelBarco == 1)
                {
                    barcoN = new Barco(); // composicion
                    barcoN = barcoN.barcoNormales(numeroBarco);
                    largoBarcosTotal = largoBarcosTotal + 2;
                    barcos[i] = barcoN;
                }

            }


        }

        // get y set de la clase
        public int LargoBarcosTotal
        {
            get
            {
                return this.largoBarcosTotal;
            }
            set
            {
                this.largoBarcosTotal = value;
            }
        }

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

        public int CantidadBarcos
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
    }
}

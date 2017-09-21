using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication3.modelos
{
    public class Barco
    {
        // Se declaran todo los atributos que va ocupar esta clase.
        string nombre, arma, imagen;
        int vida, municion, nivel;
        private Terreno terreno;
        Pnj comp;

        // e contructor de la clase.
        public Barco() { }

        // metodos de la clase:

        /* Este metodo se encarga de generar un objeto barco de nive 2.
         Recibe como parametro:
         r : Representa el numero del barco con el cual se va a crear.*/
        public Barco barcoNormales(int r)
        {
            Barco barco = new Barco();
            if (r == 0)
            {
                barco.nombre = "Colocolo";
                barco.vida = 2;
                barco.arma = "TiroRapido";
                barco.municion = 75;
                barco.nivel = 2;
                barco.imagen = "..\\..\\Imagenes\\colocolo.png";
            }

            if (r == 1)
            {
                barco.nombre = "UniversidadCatolica";
                barco.vida = 2;
                barco.arma = "TiroRapido";
                barco.municion = 75;
                barco.nivel = 2;
                barco.imagen = "..\\..\\Imagenes\\catolica.png";
            }

            if (r == 2)
            {
                barco.nombre = "Iquique";
                barco.vida = 2;
                barco.arma = "TiroRapido";
                barco.municion = 75;
                barco.nivel = 2;
                barco.imagen = "..\\..\\Imagenes\\iquique.png";
            }
            return barco;
        }

        /*Este metodo se encarga de generar un objeto barco de nive 1.
         Recibe como parametro:
         r : Representa el numero del barco con el cual se va a crear.*/
        public Barco barcoDebil(int r)
        {
            Barco barco = new Barco();
            if (r == 0)
            {
                barco.nombre = "UniversidadDeConcepcion";
                barco.arma = "Normal";
                barco.vida = 1;
                barco.municion = 100;
                barco.nivel = 1;
                barco.imagen = "..\\..\\Imagenes\\conce.png";
            }

            else if (r == 1)
            {
                barco.nombre = "SantiagoWanders";
                barco.arma = "Normal";
                barco.vida = 1;
                barco.municion = 100;
                barco.nivel = 1;
                barco.imagen = "..\\..\\Imagenes\\santiago.png";
            }

            else if (r == 2)
            {
                barco.nombre = "Everton";
                barco.arma = "Normal";
                barco.vida = 1;
                barco.municion = 100;
                barco.nivel = 1;
                barco.imagen = "..\\..\\Imagenes\\everton.png";
            }
            return barco;
        }

        /* Este metodo se encarga de generar las posiciones a cada uno de los barcos, es decir, este metodo
         otorga posiciones a todo los barcos que son generados para el enemigo.
         Tener en cuenta que genera posiciones para cada barco segun sea el nivel de este.
         Recibe como parametro:
         Barco: El barco al cual se le quiere otorgar las posiciones que va a utilizar dentro de la matriz
         Computador: Usuario oponente que esta dentro de la aplicacion
         Terreno: Variabe donde se almacena la matriz del juego , ademas es la cual se le agregaran los barcos
         enemigos, tambien otorgara la posibilidad de ver si la casilla esta vacio o ocupada.*/
        public bool colocarPos(Barco barco, Pnj computador, Terreno terreno)
        {
            this.terreno = terreno;
            this.comp = computador;
            Random r = new Random(DateTime.Now.Millisecond);
            int orientacion = r.Next(0, 2);
            int filaCp, columnaCp;
            int filaBoard = ((terreno.InfoTablero[0] / 2) - 1);
            int columnaBoard = (terreno.InfoTablero[1] - 1);
            filaCp = r.Next(0, filaBoard);
            columnaCp = r.Next(0, columnaBoard);

            if (barco.Nivel == 3)
            {
                if (orientacion == 0 && ((filaCp + 2) < filaBoard) && (columnaCp <= columnaBoard) && terreno.Casilla[filaCp, columnaCp].Estado != true)
                {
                    if (terreno.Casilla[(filaCp + 1), columnaCp].Estado != true && terreno.Casilla[(filaCp + 2), columnaCp].Estado != true)
                    {
                        terreno.Casilla[filaCp, columnaCp].Estado = true;
                        terreno.Casilla[filaCp, columnaCp].Barco = barco;
                        terreno.Casilla[(filaCp + 1), columnaCp].Estado = true;
                        terreno.Casilla[(filaCp + 1), columnaCp].Barco = barco;
                        terreno.Casilla[(filaCp + 2), columnaCp].Estado = true;
                        terreno.Casilla[(filaCp + 2), columnaCp].Barco = barco;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }

                else if (orientacion == 1 && (filaCp < filaBoard) && ((columnaCp + 2) <= columnaBoard) && terreno.Casilla[filaCp, columnaCp].Estado != true)
                {
                    if (terreno.Casilla[filaCp, (columnaCp + 1)].Estado != true && terreno.Casilla[filaCp, (columnaCp + 2)].Estado != true)
                    {
                        terreno.Casilla[filaCp, columnaCp].Estado = true;
                        terreno.Casilla[filaCp, columnaCp].Barco = barco;
                        terreno.Casilla[filaCp, (columnaCp + 1)].Estado = true;
                        terreno.Casilla[filaCp, (columnaCp + 1)].Barco = barco;
                        terreno.Casilla[filaCp, (columnaCp + 2)].Estado = true;
                        terreno.Casilla[filaCp, (columnaCp + 2)].Barco = barco;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                else
                {
                    return false;
                }
            }

            else if (barco.Nivel == 2)
            {
                if (orientacion == 0 && ((filaCp + 1) < filaBoard) && (columnaCp <= columnaBoard))
                {
                    if (terreno.Casilla[filaCp, columnaCp].Estado != true && terreno.Casilla[(filaCp + 1), columnaCp].Estado != true)
                    {
                        terreno.Casilla[filaCp, columnaCp].Estado = true;
                        terreno.Casilla[filaCp, columnaCp].Barco = barco;
                        terreno.Casilla[(filaCp + 1), columnaCp].Estado = true;
                        terreno.Casilla[(filaCp + 1), columnaCp].Barco = barco;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }

                else if (orientacion == 1 && (filaCp < filaBoard) && ((columnaCp + 1) <= columnaBoard))
                {
                    if (terreno.Casilla[filaCp, columnaCp].Estado != true && terreno.Casilla[filaCp, (columnaCp + 1)].Estado != true)
                    {
                        terreno.Casilla[filaCp, columnaCp].Estado = true;
                        terreno.Casilla[filaCp, columnaCp].Barco = barco;
                        terreno.Casilla[filaCp, (columnaCp + 1)].Estado = true;
                        terreno.Casilla[filaCp, (columnaCp + 1)].Barco = barco;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

                else
                {
                    return false;
                }

            }

            else if (barco.Nivel == 1)
            {
                if (filaCp < filaBoard)
                {
                    if (terreno.Casilla[filaCp, columnaCp].Estado != true)
                    {
                        terreno.Casilla[filaCp, columnaCp].Estado = true;
                        terreno.Casilla[filaCp, columnaCp].Barco = barco;
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                }
                else
                {
                    return false;
                }
            }
            else { return false; }
        }
        
        /*Funcion que se encarga de verificar si una posicion se encuentra en estado disponible o no.
         Recibe como parametro:
         Fila y columna: Son las coordenadas de la casilla que se quiere verificar su estado.
         Terreno: Es donde se quiere verificar el estado de la casilla.*/
        public bool comprobarPos(int fila, int columna, Terreno terreno)
        {
            this.terreno = terreno;

            if (terreno.Casilla[fila, columna].Estado)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        /*Este metodo se encarga de generar un objeto barco jefe de nivel 3.
        Recibe como parametro:
         r : Representa el numero del barco con el cual se va a crear.*/
        public Barco jefeBarco(int r, string nombre)
        {
            Barco barco = new Barco();
            if (nombre == "UniversidadDeChile")
            {
                barco.nombre = "UniversidadDeChile";
                barco.vida = 3;
                barco.arma = "Chilena";
                barco.municion = 50;
                barco.nivel = 3;
                barco.imagen = "..\\..\\Imagenes\\universidaddechile.png";
            }

            if (nombre == "UnionEspañola")
            {
                barco.nombre = "UnionEspañola";
                barco.vida = 3;
                barco.arma = "Chilena";
                barco.municion = 50;
                barco.nivel = 3;
                barco.imagen = "..\\..\\Imagenes\\union.png";
            }
            return barco;
        }

        /*Este metodo se encarga de generar un objeto barco jefe de nivel 3
        Recibe como parametro:
        r : Representa el numero del barco con el cual se va a crear.*/
        public Barco jefeBarcoN(string nombreB)
        {
            Barco barco = new Barco();
            if (nombreB != "UniversidadDeChile")
            {
                barco.nombre = "UniversidadDeChile";
                barco.vida = 3;
                barco.arma = "Chilena";
                barco.municion = 50;
                barco.nivel = 3;
                barco.imagen = "..\\..\\Imagenes\\universidaddechile.png";
            }

            if (nombreB != "UnionEspañola")
            {
                barco.nombre = "UnionEspañola";
                barco.vida = 3;
                barco.arma = "Chilena";
                barco.municion = 50;
                barco.nivel = 3;
                barco.imagen = "..\\..\\Imagenes\\union.png";
            }
            return barco;
        }

        public override string ToString()
        {
            return Nombre;
        }

        // get -> Obtiene valores 
        // set -> Asigna valores
        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }

        public string Arma
        {
            get
            {
                return this.arma;
            }
            set
            {
                this.arma = value;
            }
        }

        public string Imagen
        {
            get
            {
                return this.imagen;
            }
            set
            {
                this.imagen = value;
            }
        }

        public int Vida
        {
            get
            {
                return this.vida;
            }
            set
            {
                this.vida = value;
            }
        }

        public int Municion
        {
            get
            {
                return this.municion;
            }
            set
            {
                this.municion = value;
            }
        }

        public int Nivel
        {
            get
            {
                return this.nivel;
            }
            set
            {
                this.nivel = value;
            }
        }
    }
}

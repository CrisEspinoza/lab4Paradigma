using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApplication3.Vistas;
using System.Windows.Forms;
using WindowsFormsApplication3.ServiceReference1;

namespace WindowsFormsApplication3.modelos
{
    public class Terreno 
    {
        // Se decalran los atributos que seran ocupados dentro de la clase.
        int[] infoTablero;
        public int time;
        string equipoPreferido,nivel;
        Casilla[,] casilla; // agregacion 
        int cantBarcosTerreno;
        Terreno terreno; // agregacion 
        Pnj comp; // agregacion 
        VistaTerreno vt; // agregacion 
        Casilla casillaMia; // agregacion 
        Jugador jugador; // agregacion  
        Barco jefeUsuario = new Barco();  // composicoin 
        public List<Barco> listaGeneral; // agregacion 
        Barco barco = new Barco(); // composicoin 
        int fila, columna, filaCp, columnaCp;
        bool estado;
        int  puntajeUsu, puntajeCom;
        public bool bandera = false;
        public bool bandera1 = false;
        public bool bandera2 = false;

        // Se declaran los contructores de la clase.

        // Se declara un constructor vacio.
        public Terreno() { }

        /* Se declara un contructor que contiene todo los datos que ingresa el usuario, al momento de pasar la vista 
        que solicta la totalidad de los datos.*/
        public Terreno(Jugador jugador, int fila, int columna, int numBarcoUsuario, int numBarcoEnemigo, String nivel, string equipoPreferido,Pnj computador, int tiempoo,VistaTerreno vt)
        {
            this.vt=vt;
            this.jugador = jugador;
            this.comp = computador;
            this.time = tiempoo;
            this.infoTablero = new int[4];
            this.infoTablero[0] = fila;
            this.infoTablero[1] = columna;
            this.infoTablero[2] = numBarcoUsuario;
            this.infoTablero[3] = numBarcoEnemigo;
            this.cantBarcosTerreno = numBarcoUsuario;
            this.nivel = nivel;
            this.equipoPreferido = equipoPreferido;
            casilla = new Casilla[fila , columna];
            listaGeneral = new List<Barco>();
            jefeUsuario = barco.jefeBarco(0, this.EquipoPreferido);
            jugador.Barcos[0] = jefeUsuario;
            listaGeneral.Add(jugador.Barcos[0]);
            for (int i = 0; i < 3; i++)
            {
                Barco aux = barco.barcoDebil(i);
                Barco aux1 = barco.barcoNormales(i);
                listaGeneral.Add(aux);
                listaGeneral.Add(aux1);
            }
        }

        // Metodos:

        /* Metodo que se encarga de realizar el ataque:
        Recibe como parametro: 
        CasillaMia: Corresponde a la casilla seleccionada de donde se encuentre el barco con el cual quiere
        realizar el ataque.
        CasillaEnem: Corresponde a la casilla a la que se le efectuara el ataque
        Terreno: Es donde se realizaran las modificaciones al momento de generar el disparo.*/
        public int ataque(Casilla casillaMia, Casilla casillaEnem, Terreno terreno)
        {
            this.casillaMia = casillaMia;

            // Se instacia el servicio, con le fin de podr utilzaro para ir actulizando el puntaje del usuario.
            Service1Client servicio = new Service1Client();
            if (bandera2)
            {//ver las armas.
                if (casillaEnem.Estado)
                {
                    terreno.Casilla[casillaEnem.Fila, casillaEnem.Columna].Barco.Vida--;

                    if (terreno.Casilla[casillaEnem.Fila, casillaEnem.Columna].Barco.Vida == 0)
                    {
                        comp.CantidadBarcos--;
                        terreno.Casilla[casillaEnem.Fila, casillaEnem.Columna].Estado = false;
                        MessageBox.Show("Equipo " + terreno.Casilla[casillaEnem.Fila, casillaEnem.Columna].Barco.Nombre + "derrotado");
                        terreno.Casilla[casillaEnem.Fila, casillaEnem.Columna].Image = Image.FromFile("..\\..\\Imagenes\\gol.png");
                        terreno.Casilla[casillaEnem.Fila, casillaEnem.Columna].ImageAlign = ContentAlignment.TopCenter;
                        bandera1 = false;
                        vt.comprobarGanador(comp, jugador);
                        if (terreno.Casilla[casillaMia.Fila, casillaMia.Columna].Barco.Arma == "Normal")
                        {
                            puntajeUsu = puntajeUsu + 1000;
                            jugador.Puntaje = puntajeUsu;
                            vt.labelPuntajeUsuario.Text = puntajeUsu.ToString();
                            /* Este linea que sigue acontinuacio se encarga de ir actualizando el puntaje que se encuentra
                             en la tabala de usuario del jugador, tener encuentra que lo hace de manera asincronina, ademas
                             de hacerla cada ves que se realiza una jugada con algun exito, ya sea que derroto al barco o
                             derribo cierta parte de el*/
                            servicio.actualizarPuntajeAsync(puntajeUsu,jugador.Nombre);
                        }
                        else if (terreno.Casilla[casillaMia.Fila, casillaMia.Columna].Barco.Arma == "TiroRapido")
                        {
                            puntajeUsu = puntajeUsu + 1250;
                            MessageBox.Show("El equipo" + terreno.Casilla[casillaMia.Fila, casillaMia.Columna].Barco.Nombre + "ataco con la arma *TiroRapido* otorga un bonus de 250 de puntaje!!");
                            jugador.Puntaje = puntajeUsu;
                            vt.labelPuntajeUsuario.Text = puntajeUsu.ToString();
                            /* Este linea que sigue acontinuacio se encarga de ir actualizando el puntaje que se encuentra
                             en la tabala de usuario del jugador, tener encuentra que lo hace de manera asincronina, ademas
                             de hacerla cada ves que se realiza una jugada con algun exito, ya sea que derroto al barco o
                             derribo cierta parte de el*/
                            servicio.actualizarPuntajeAsync(puntajeUsu, jugador.Nombre);
                        }
                        else if (terreno.Casilla[casillaMia.Fila, casillaMia.Columna].Barco.Arma == "Chilena")
                        {
                            puntajeUsu = puntajeUsu + 1500;
                            MessageBox.Show("El equipo" + terreno.Casilla[casillaMia.Fila, casillaMia.Columna].Barco.Nombre + "la arma *Chilena* otorga un bonus de 500 de puntaje!!");
                            jugador.Puntaje = puntajeUsu;
                            vt.labelPuntajeUsuario.Text = puntajeUsu.ToString();
                            /* Este linea que sigue acontinuacio se encarga de ir actualizando el puntaje que se encuentra
                             en la tabala de usuario del jugador, tener encuentra que lo hace de manera asincronina, ademas
                             de hacerla cada ves que se realiza una jugada con algun exito, ya sea que derroto al barco o
                             derribo cierta parte de el*/
                            servicio.actualizarPuntajeAsync(puntajeUsu, jugador.Nombre);
                        }
                        playCp(terreno, casillaEnem);
                        terreno.Casilla[casillaEnem.Fila, casillaEnem.Columna].Barco = null;
                        return 2;
                    }
                    else
                    {
                        casillaMia.Barco.Municion--;
                        bandera1 = false;
                        terreno.Casilla[casillaEnem.Fila, casillaEnem.Columna].Estado = false;
                        terreno.Casilla[casillaEnem.Fila, casillaEnem.Columna].Image = Image.FromFile("..\\..\\Imagenes\\gol.png");
                        terreno.Casilla[casillaEnem.Fila, casillaEnem.Columna].ImageAlign = ContentAlignment.TopCenter;
                        MessageBox.Show("Barco enemigo atacado");
                        if (terreno.Casilla[casillaMia.Fila, casillaMia.Columna].Barco.Arma == "Normal")
                        {
                            puntajeUsu = puntajeUsu + 1000;
                            jugador.Puntaje = puntajeUsu;
                            vt.labelPuntajeUsuario.Text = puntajeUsu.ToString();
                            /* Este linea que sigue acontinuacio se encarga de ir actualizando el puntaje que se encuentra
                             en la tabala de usuario del jugador, tener encuentra que lo hace de manera asincronina, ademas
                             de hacerla cada ves que se realiza una jugada con algun exito, ya sea que derroto al barco o
                             derribo cierta parte de el*/
                            servicio.actualizarPuntajeAsync(puntajeUsu, jugador.Nombre);
                        }
                        else if (terreno.Casilla[casillaMia.Fila, casillaMia.Columna].Barco.Arma == "TiroRapido")
                        {
                            puntajeUsu = puntajeUsu + 1250;
                            MessageBox.Show("El equipo" + terreno.Casilla[casillaMia.Fila, casillaMia.Columna].Barco.Nombre + "la arma *TiroRapido* otorga un bonus de 250 de puntaje!!");
                            jugador.Puntaje = puntajeUsu;
                            vt.labelPuntajeUsuario.Text = puntajeUsu.ToString();
                            /* Este linea que sigue acontinuacio se encarga de ir actualizando el puntaje que se encuentra
                             en la tabala de usuario del jugador, tener encuentra que lo hace de manera asincronina, ademas
                             de hacerla cada ves que se realiza una jugada con algun exito, ya sea que derroto al barco o
                             derribo cierta parte de el*/
                            servicio.actualizarPuntajeAsync(puntajeUsu, jugador.Nombre);
                        }
                        else if (terreno.Casilla[casillaMia.Fila, casillaMia.Columna].Barco.Arma == "Chilena")
                        {
                            puntajeUsu = puntajeUsu + 1500;
                            MessageBox.Show("El equipo" + terreno.Casilla[casillaMia.Fila, casillaMia.Columna].Barco.Nombre + "la arma *Chilena* otorga un bonus de 500 de puntaje!!");
                            jugador.Puntaje = puntajeUsu;
                            vt.labelPuntajeUsuario.Text = puntajeUsu.ToString();
                            /* Este linea que sigue acontinuacio se encarga de ir actualizando el puntaje que se encuentra
                             en la tabala de usuario del jugador, tener encuentra que lo hace de manera asincronina, ademas
                             de hacerla cada ves que se realiza una jugada con algun exito, ya sea que derroto al barco o
                             derribo cierta parte de el*/
                            servicio.actualizarPuntajeAsync(puntajeUsu, jugador.Nombre);
                        }
                        playCp(terreno, casillaEnem);
                        terreno.Casilla[casillaEnem.Fila, casillaEnem.Columna].Barco = null;
                        terreno.Casilla[casillaEnem.Fila, casillaEnem.Columna].Atacado = true;
                        return 1;
                    }
                }
                else
                {
                    MessageBox.Show("La casilla esta vacia");
                    casillaMia.Barco.Municion--;
                    terreno.Casilla[casillaEnem.Fila, casillaEnem.Columna].Image = Image.FromFile("..\\..\\Imagenes\\nada.png");
                    terreno.Casilla[casillaEnem.Fila, casillaEnem.Columna].ImageAlign = ContentAlignment.TopCenter;
                    playCp(terreno, casillaEnem);
                    bandera1 = false;
                    terreno.Casilla[casillaEnem.Fila, casillaEnem.Columna].Atacado = true;
                    return 0;
                }
            }
            else
            {
                return 0;
            }
        }

        /*Funcion que se encarga de posicionar un barco en donde seleccione el usuario.
         Recibe como parametro:
         Fil y columna: Coordenadas de donde quiere posicionar el barco.
         Estado: Condicion en la cual se encuentra la casilla que selecciono el usuario para colocar su barco
         Terreno: Variable que contiene la matriz de juego y es donde se realizaran las modificaciones al momento
         que se coloque un barco dentro de la matriz
         Barco: Barco que el usuario escoge para colocarlo dentro de su matriz.*/
        public void putShip(int fila, int columna, bool estado, Terreno terreno, Barco barco)
        {
            this.fila = fila;
            this.columna = columna;
            this.estado = estado;
            this.terreno = terreno;
            filaCp = ((terreno.InfoTablero[0] / 2));
            columnaCp = (terreno.InfoTablero[1] - 1);

            if (terreno.Casilla[fila, columna].Estado)
            { }
            else if (fila > filaCp)
            {
                if (barco.Nivel == 1)
                {
                    terreno.Casilla[fila, columna].Barco = barco;
                    terreno.Casilla[fila, columna].estado = true;
                    terreno.Casilla[fila, columna].Image = Image.FromFile(comp.Terreno.Casilla[fila, columna].Barco.Imagen);
                    bandera = false;
                    jugador.Barcos[jugador.BarcosActuales] = barco;
                    jugador.BarcosActuales = jugador.BarcosActuales + 1;
                }

                else if (barco.Vida == 2)
                {
                    if ((fila + 1) > filaCp && (fila + 1) < terreno.InfoTablero[0])
                    {
                        if (terreno.Casilla[fila + 1, columna].Estado != true)
                        {
                            terreno.Casilla[fila, columna].Barco = barco;
                            terreno.Casilla[fila, columna].estado = true;
                            terreno.Casilla[fila, columna].Image = Image.FromFile(comp.Terreno.Casilla[fila, columna].Barco.Imagen);
                            terreno.Casilla[fila + 1, columna].Barco = barco;
                            terreno.Casilla[fila + 1, columna].estado = true;
                            terreno.Casilla[fila + 1, columna].Image = Image.FromFile(comp.Terreno.Casilla[fila, columna].Barco.Imagen);
                            bandera = false;
                            jugador.Barcos[jugador.BarcosActuales] = barco;
                            jugador.BarcosActuales = jugador.BarcosActuales + 1;
                        }

                        else
                        {
                            bandera = true;
                        }
                    }

                    else if ((fila - 1) > filaCp && (fila - 1) < terreno.InfoTablero[0])
                    {
                        if (terreno.Casilla[fila - 1, columna].Estado != true)
                        {
                            terreno.Casilla[fila, columna].Barco = barco;
                            terreno.Casilla[fila, columna].estado = true;
                            terreno.Casilla[fila, columna].Image = Image.FromFile(comp.Terreno.Casilla[fila, columna].Barco.Imagen);
                            terreno.Casilla[fila - 1, columna].Barco = barco;
                            terreno.Casilla[fila - 1, columna].estado = true;
                            terreno.Casilla[fila - 1, columna].Image = Image.FromFile(comp.Terreno.Casilla[fila, columna].Barco.Imagen);
                            bandera = false;
                            jugador.Barcos[jugador.BarcosActuales] = barco;
                            jugador.BarcosActuales = jugador.BarcosActuales + 1;
                        }

                        else
                        {
                            bandera = true;
                        }
                    }

                    else if ((columna + 1) <= columnaCp && (columna + 1) < terreno.InfoTablero[1])
                    {
                        if (terreno.Casilla[fila, columna + 1].Estado != true)
                        {
                            terreno.Casilla[fila, columna].Barco = barco;
                            terreno.Casilla[fila, columna].estado = true;
                            terreno.Casilla[fila, columna].Image = Image.FromFile(comp.Terreno.Casilla[fila, columna].Barco.Imagen);
                            terreno.Casilla[fila, columna + 1].Barco = barco;
                            terreno.Casilla[fila, columna + 1].estado = true;
                            terreno.Casilla[fila, columna + 1].Image = Image.FromFile(comp.Terreno.Casilla[fila, columna].Barco.Imagen);
                            bandera = false;
                            jugador.Barcos[jugador.BarcosActuales] = barco;
                            jugador.BarcosActuales = jugador.BarcosActuales + 1;
                        }

                        else
                        {
                            bandera = true;
                        }
                    }

                    else if ((columna - 1) <= columnaCp && (columna - 1) < terreno.InfoTablero[1])
                    {
                        if (terreno.Casilla[fila, columna - 1].Estado != true)
                        {
                            terreno.Casilla[fila, columna].Barco = barco;
                            terreno.Casilla[fila, columna].estado = true;
                            terreno.Casilla[fila, columna].Image = Image.FromFile(comp.Terreno.Casilla[fila, columna].Barco.Imagen);
                            terreno.Casilla[fila, columna - 1].Barco = barco;
                            terreno.Casilla[fila, columna - 1].estado = true;
                            terreno.Casilla[fila, columna - 1].Image = Image.FromFile(comp.Terreno.Casilla[fila, columna].Barco.Imagen);
                            bandera = false;
                            jugador.Barcos[jugador.BarcosActuales] = barco;
                            jugador.BarcosActuales = jugador.BarcosActuales + 1;
                        }

                        else
                        {
                            bandera = true;
                        }
                    }
                }

                else if (barco.Vida == 3)
                {
                    if ((fila + 2) > filaCp && (fila + 2) < terreno.InfoTablero[0])
                    {
                        if (terreno.Casilla[fila + 1, columna].Estado != true && terreno.Casilla[fila + 2, columna].Estado != true)
                        {
                            terreno.Casilla[fila, columna].Barco = barco;
                            terreno.Casilla[fila, columna].estado = true;
                            terreno.Casilla[fila, columna].Image = Image.FromFile(comp.Terreno.Casilla[fila, columna].Barco.Imagen);
                            terreno.Casilla[fila + 1, columna].Barco = barco;
                            terreno.Casilla[fila + 1, columna].estado = true;
                            terreno.Casilla[fila + 1, columna].Image = Image.FromFile(comp.Terreno.Casilla[fila, columna].Barco.Imagen);
                            terreno.Casilla[fila + 2, columna].Barco = barco;
                            terreno.Casilla[fila + 2, columna].estado = true;
                            terreno.Casilla[fila + 2, columna].Image = Image.FromFile(comp.Terreno.Casilla[fila, columna].Barco.Imagen);
                            bandera = false;
                            jugador.Barcos[jugador.BarcosActuales] = barco;
                            jugador.BarcosActuales = jugador.BarcosActuales + 1;
                        }

                        else
                        {
                            bandera = true;
                        }
                    }

                    else if ((fila - 2) > filaCp && (fila - 2) < terreno.InfoTablero[0])
                    {
                        if (terreno.Casilla[fila - 1, columna].Estado != true && terreno.Casilla[fila - 2, columna].Estado != true)
                        {
                            terreno.Casilla[fila, columna].Barco = barco;
                            terreno.Casilla[fila, columna].estado = true;
                            terreno.Casilla[fila, columna].Image = Image.FromFile(comp.Terreno.Casilla[fila, columna].Barco.Imagen);
                            terreno.Casilla[fila - 1, columna].Barco = barco;
                            terreno.Casilla[fila - 1, columna].estado = true;
                            terreno.Casilla[fila - 1, columna].Image = Image.FromFile(comp.Terreno.Casilla[fila, columna].Barco.Imagen);
                            terreno.Casilla[fila - 2, columna].Barco = barco;
                            terreno.Casilla[fila - 2, columna].estado = true;
                            terreno.Casilla[fila - 2, columna].Image = Image.FromFile(comp.Terreno.Casilla[fila, columna].Barco.Imagen);
                            bandera = false;
                            jugador.Barcos[jugador.BarcosActuales] = barco;
                            jugador.BarcosActuales = jugador.BarcosActuales + 1;
                        }

                        else
                        {
                            bandera = true;
                        }
                    }

                    else if ((columna + 2) <= columnaCp && (columna + 2) < terreno.InfoTablero[1])
                    {
                        if (terreno.Casilla[fila, columna + 1].Estado != true && terreno.Casilla[fila, columna + 2].Estado != true)
                        {
                            terreno.Casilla[fila, columna].Barco = barco;
                            terreno.Casilla[fila, columna].estado = true;
                            terreno.Casilla[fila, columna].Image = Image.FromFile(comp.Terreno.Casilla[fila, columna].Barco.Imagen);
                            terreno.Casilla[fila, columna + 1].Barco = barco;
                            terreno.Casilla[fila, columna + 1].estado = true;
                            terreno.Casilla[fila, columna + 1].Image = Image.FromFile(comp.Terreno.Casilla[fila, columna].Barco.Imagen);
                            terreno.Casilla[fila, columna + 2].Barco = barco;
                            terreno.Casilla[fila, columna + 2].estado = true;
                            terreno.Casilla[fila, columna + 2].Image = Image.FromFile(comp.Terreno.Casilla[fila, columna].Barco.Imagen);
                            bandera = false;
                            jugador.Barcos[jugador.BarcosActuales] = barco;
                            jugador.BarcosActuales = jugador.BarcosActuales + 1;
                        }

                        else
                        {
                            bandera = true;
                        }
                    }

                    else if ((columna - 2) <= columnaCp && (columna - 2) < terreno.InfoTablero[1] && (columna -2 ) > 0)
                    {
                        if (terreno.Casilla[fila, columna - 1].Estado != true && terreno.Casilla[fila, columna - 2].Estado != true)
                        {
                            terreno.Casilla[fila, columna].Barco = barco;
                            terreno.Casilla[fila, columna].estado = true;
                            terreno.Casilla[fila, columna].Image = Image.FromFile(comp.Terreno.Casilla[fila, columna].Barco.Imagen);
                            terreno.Casilla[fila, columna - 1].Barco = barco;
                            terreno.Casilla[fila, columna - 1].estado = true;
                            terreno.Casilla[fila, columna - 1].Image = Image.FromFile(comp.Terreno.Casilla[fila, columna].Barco.Imagen);
                            terreno.Casilla[fila, columna - 2].Barco = barco;
                            terreno.Casilla[fila, columna - 2].estado = true;
                            terreno.Casilla[fila, columna - 2].Image = Image.FromFile(comp.Terreno.Casilla[fila, columna].Barco.Imagen);
                            bandera = false;
                            jugador.Barcos[jugador.BarcosActuales] = barco;
                            jugador.BarcosActuales = jugador.BarcosActuales + 1;
                        }

                        else
                        {
                            bandera = true;
                        }
                    }
                }

                else
                {
                    bandera = true;
                }
            }
        }

        /*Funcion que realiza el ataque enemigo dentro de la matriz.
         Recibe como parametro:
         Terreno: Variable en la cual contiene la matriz de juego y es donde se realizaran las modificaciones al
         momento de efectuar el ataque.
         CasillaEnem: Casilla enemiga que selecciono el usario para realizar el ataque
         */
        public void playCp(Terreno terreno, Casilla casillaEnem)
        {
            int barcoAtaque;
            int ataqueFila;
            int ataqueColumna;
            Random e = new Random();
            for (int i = 0; i < 1; i++)
            {
                /*/ Se obtiene a traves de un random el barco con el cual se va a realizar el ataque ademas 
                de las coordenadas de donde se va a realizar el atque de la computadora*/
                barcoAtaque = e.Next(comp.CantidadBarcos);
                ataqueFila = e.Next(((terreno.InfoTablero[0] / 2) + 1), terreno.InfoTablero[0]);
                ataqueColumna = e.Next(terreno.InfoTablero[1]);
                Console.WriteLine("fila : {0} ---- columna : {1}", ataqueFila, ataqueColumna);

                if (terreno.Casilla[ataqueFila, ataqueColumna].Atacado != true)
                {
                    if (terreno.Casilla[ataqueFila, ataqueColumna].Estado)
                    {
                        terreno.Casilla[ataqueFila, ataqueColumna].Barco.Vida--;
                        if ((terreno.Casilla[ataqueFila, ataqueColumna].Barco.Vida) == 0)
                        {
                            MessageBox.Show("Computador derroto a " + terreno.Casilla[ataqueFila, ataqueColumna].Barco.Nombre);
                            comp.barcos[barcoAtaque].Municion--;
                            jugador.BarcosActuales--;
                            terreno.Casilla[ataqueFila, ataqueColumna].Image = Image.FromFile("..\\..\\Imagenes\\gol.png");
                            terreno.Casilla[ataqueFila, ataqueColumna].ImageAlign = ContentAlignment.TopCenter;
                            terreno.Casilla[ataqueFila, ataqueColumna].Estado = false;
                            vt.comprobarGanador(comp, jugador);
                            bandera2 = false;
                            if ((comp.Barcos[barcoAtaque].Arma == "Normal"))
                            {
                                puntajeCom = puntajeCom + 1000;
                                comp.Puntaje = puntajeCom;
                                vt.labelPuntajeCompu.Text = puntajeCom.ToString();
                            }
                            else if ((comp.Barcos[barcoAtaque].Arma == "TiroRapido"))
                            {
                                puntajeCom = puntajeCom + 1250;
                                MessageBox.Show("El equipo" + comp.Barcos[barcoAtaque].Nombre + "ataco con la arma *TiroRapido* otorga un bonus de 250 de puntaje!!");
                                comp.Puntaje = puntajeCom;
                                vt.labelPuntajeCompu.Text = puntajeCom.ToString();
                            }
                            else if ((comp.Barcos[barcoAtaque].Arma == "Chilena"))
                            {
                                puntajeCom = puntajeCom + 1500;
                                MessageBox.Show("El equipo" + comp.Barcos[barcoAtaque].Nombre + "ataco con la arma *Chilena* otorga un bonus de 500 de puntaje!!");
                                comp.Puntaje = puntajeCom;
                                vt.labelPuntajeCompu.Text = puntajeCom.ToString();
                            }
                            terreno.Casilla[ataqueFila, ataqueColumna].Barco = null;
                            terreno.Casilla[ataqueFila, ataqueColumna].Atacado = true;
                            Console.WriteLine(terreno.Casilla[ataqueFila, ataqueColumna].Atacado);
                        }

                        else
                        {
                            MessageBox.Show("Disparo a " + terreno.Casilla[ataqueFila, ataqueColumna].Barco.Nombre);
                            comp.barcos[barcoAtaque].Municion--;
                            terreno.Casilla[ataqueFila, ataqueColumna].Image = Image.FromFile("..\\..\\Imagenes\\gol.png");
                            terreno.Casilla[ataqueFila, ataqueColumna].ImageAlign = ContentAlignment.TopCenter;
                            terreno.Casilla[ataqueFila, ataqueColumna].Barco = null;
                            terreno.Casilla[ataqueFila, ataqueColumna].Estado = false;
                            bandera2 = false;

                            if ((comp.Barcos[barcoAtaque].Arma == "Normal"))
                            {
                                puntajeCom = puntajeCom + 1000;
                                comp.Puntaje = puntajeCom;
                                vt.labelPuntajeCompu.Text = puntajeCom.ToString();
                            }
                            else if ((comp.Barcos[barcoAtaque].Arma == "TiroRapido"))
                            {
                                puntajeCom = puntajeCom + 1250;
                                MessageBox.Show("El equipo" + comp.Barcos[barcoAtaque].Nombre + "ataco con la arma *TiroRapido* otorga un bonus de 250 de puntaje!!");
                                comp.Puntaje = puntajeCom;
                                vt.labelPuntajeCompu.Text = puntajeCom.ToString();
                            }
                            else if ((comp.Barcos[barcoAtaque].Arma == "Chilena"))
                            {
                                puntajeCom = puntajeCom + 1500;
                                MessageBox.Show("El equipo" + comp.Barcos[barcoAtaque].Nombre + "ataco con la arma *Chilena* otorga un bonus de 500 de puntaje!!");
                                comp.Puntaje = puntajeCom;
                                vt.labelPuntajeCompu.Text = puntajeCom.ToString();
                            }
                            terreno.Casilla[ataqueFila,ataqueColumna].Atacado = true;
                            Console.WriteLine(terreno.Casilla[ataqueFila, ataqueColumna].Atacado);
                        }
                    }
                    else
                    {
                        comp.barcos[barcoAtaque].Municion--;
                        terreno.Casilla[ataqueFila, ataqueColumna].Image = Image.FromFile("..\\..\\Imagenes\\nada.png");
                        terreno.Casilla[ataqueFila, ataqueColumna].ImageAlign = ContentAlignment.TopCenter;
                        bandera2 = false;
                        terreno.Casilla[ataqueFila,ataqueColumna].Atacado = true;
                        Console.WriteLine(terreno.Casilla[ataqueFila, ataqueColumna].Atacado);
                        MessageBox.Show("Disparo fallido del enemigo");
                    }
                }

                else
                {
                    i--;
                }
            }
        }

        /*Funcion que se encarga de colocar las imagenes de los barcos que se encuentran dentro de la matriz 
         ademas de colocar pasto si la casilla esta desocupada y tambien hacer la verificacion en la mitad del 
         terreno, para que se puede diferenciar el terreno de cada uno de los jugadores.
         Recibe como parametro:
         Terreno: Es el terreno al cual se el colocaran las imagenes.
         Computador: Es el usuario enemigo que esta dentro de la partida.*/
        public Terreno verImagen(Terreno terreno, Pnj Computador)
        {
            this.terreno = terreno;
            this.comp = Computador;

            for (int i = 0; i < terreno.InfoTablero[0]; i++)
            {
                for (int j = 0; j < terreno.InfoTablero[1]; j++)
                {
                    if (comp.Terreno.Casilla[i, j].Estado)
                    {
                        if ((terreno.InfoTablero[0] / 2 <= i))
                        {
                            terreno.Casilla[i, j].Image = Image.FromFile(comp.Terreno.Casilla[i, j].Barco.Imagen);
                            terreno.Casilla[i, j].ImageAlign = ContentAlignment.TopCenter;
                        }
                        else
                        {
                            terreno.Casilla[i, j].Image = Image.FromFile("..\\..\\Imagenes\\casilla.png");
                            terreno.Casilla[i, j].ImageAlign = ContentAlignment.TopCenter;
                        }
                    }

                    else if (i == (terreno.InfoTablero[0] / 2))
                    {
                        terreno.Casilla[i, j].Image = Image.FromFile("..\\..\\Imagenes\\banda.png");
                    }

                    else
                    {
                        terreno.Casilla[i, j].Image = Image.FromFile("..\\..\\Imagenes\\casilla.png");
                        terreno.Casilla[i, j].ImageAlign = ContentAlignment.TopCenter;
                    }
                }
            }
            comp.Terreno = terreno;
            // MessageBox.Show("Ha escogido le nivel " + terreno.Nivel + "que se conforma de" + terreno.InfoTablero[2].ToString() + "barcos enemigos");
            return terreno;
        }

        /*Funcion que se encara de crear la matriz que se ocupara dentro del juego.
        Recibe como parametro:
        Terreno: Es donde se guardara la matri del juego.
        Vt: Es la vista donde se encuentra el panel donde se ubicara la matriz de juego.*/

        public Terreno createBoard(Terreno terreno, VistaTerreno vt)
        {
            this.vt = vt;
            Random r = new Random();
            this.terreno = terreno;
            int x = 25;
            int y = 25;

            for (int i = 0; i < terreno.InfoTablero[0]; i++)
            {
                for (int j = 0; j < terreno.InfoTablero[1]; j++)
                {
                    Casilla casilla = new Casilla(i, j, false, null);
                    casilla.Location = new Point(x, y);
                    casilla.Click += new EventHandler(vt.acciones);
                    terreno.Casilla[i, j] = casilla;
                    vt.panelTablero.Controls.Add(casilla);
                    x += 35;
                }
                x = 25;
                y += 35;
            }
            return terreno;
        }
                
        /*Fucion que verfiica si el tablero creado es valido para ser utilizado en una partida
         Recibe como parametro:
         Terreno: Variable donde se encuentra la matriz que se genero.*/
        public bool checkBoard(Terreno terreno)
        {
            int largoTerreno;
            largoTerreno = (terreno.InfoTablero[0] / 2) * terreno.InfoTablero[1];

            if (terreno.InfoTablero[0] % 2 == 0)
            {
                if (comp.largoBarcosTotal < largoTerreno)
                {
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

        /*Funcion que se encarga de actulizar el tablero y ocultar los barcos del enemigo, es la ultima actualizacion
         del tablero antes de comenzar la partida
         Recibe como parametro:
         Terreno: Es donde se encuentra almacenada la matriz que se utilizara para el juego.*/
        public void actualizarTablero(Terreno terreno)
        {
            int mitadTablero = (terreno.InfoTablero[0] / 2);
            for (int i = 0; i < terreno.InfoTablero[0]; i++)
            {
                for (int j = 0; j < terreno.InfoTablero[1]; j++)
                {
                    if (mitadTablero > i)
                    {
                        terreno.Casilla[i, j].Image = Image.FromFile("..\\..\\Imagenes\\casilla.png");
                        terreno.Casilla[i, j].ImageAlign = ContentAlignment.TopCenter;
                    }
                }
            }
        }

        /*Funcion que realiza el llamado para posicionar los barcos del enemigo dentro de la matriz de juego
         Recibe como parametro:
         Terreno: Es donde se almacena la matriz de jueg y donde se colocaran los barcos del enemigo.
         Computador: Es donde esta el enemigo con los barcos que fueron seleccionados al azar para esta partida
         ademas de contener cada una de las posiciones de sus barcos.*/
        public void posicionarBarcos(Pnj computador, Terreno terreno)
        {
            this.terreno = terreno;
            this.comp = computador;
            for (int i = 0; i < comp.barcos.Length; i++)
            {
                if (barco.colocarPos(comp.barcos[i], comp, this.terreno)) { }
                else
                {
                    i--;
                }
            }
            comp.Terreno = this.terreno;
        }

        // get y set de la clase
        public String Nivel
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

        public int CantBarcosTerreno
        {
            get
            {
                return this.cantBarcosTerreno;
            }
            set
            {
                this.cantBarcosTerreno = value;
            }
        }

        public String EquipoPreferido
        {
            get
            {
                return this.equipoPreferido;
            }
            set
            {
                this.equipoPreferido = value;
            }
        }

        public int[] InfoTablero
        {
            get
            {
                return this.infoTablero;
            }
            set
            {
                this.infoTablero = value;
            }
        }

        public Casilla[,] Casilla
        {
            get
            {
                return this.casilla;
            }
            set
            {
                this.casilla = value;
            }
        }
    }
}

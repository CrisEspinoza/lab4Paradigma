namespace WindowsFormsApplication3.modelos
{
    public class Usuario
    {
        // Se declaran los atributos que seran ocpados dentro de la clase.
        string nombre,apodo ,contraseña, equipoPreferida;
        Terreno terreno; // agregacion.

        // Se declara un contrsutor para la clase.
        public Usuario()
        {

        }

        // get y set de la clase.
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

        public string Apodo
        {
            get
            {
                return this.apodo;
            }
            set
            {
                this.apodo = value;
            }
        }

        public string Contraseña
        {
            get
            {
                return this.contraseña;
            }
            set
            {
                this.contraseña = value;
            }
        }

        public string EquipoPreferido
        {
            get
            {
                return this.equipoPreferida;
            }
            set
            {
                this.equipoPreferida = value;
            }
        }

        public Terreno Terreno 
        {
            get
            {
                return this.terreno;
            }
            set
            {
                this.terreno = value;
            }
        }
    }
}
